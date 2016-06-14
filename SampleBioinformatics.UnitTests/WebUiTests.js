/// <reference path="..\SampleBioinformatics.Web\Scripts\angular.js"/>
/// <reference path="..\SampleBioinformatics.Web\Scripts\angular-ui-router.js"/>
/// <reference path=".\Scripts\angular-mocks.js"/>

/// <reference path="..\SampleBioinformatics.Web\app\app.js"/>
/// <reference path="..\SampleBioinformatics.Web\app\index.js"/>

describe("UI", function () {

    var index;

    beforeEach(angular.mock.module("bio"));

    beforeEach(inject(function ($controller) {
        index = $controller("index");
    }));

    beforeEach(inject(function ($injector) {
        $httpBackend = $injector.get("$httpBackend");
        requestHandler = $httpBackend.when("GET", function (url) {
            return url.indexOf("/api/SampleBioinformatics/GetDNADecoded") === 0;
        })
    }));

    afterEach(function () {
        $httpBackend.verifyNoOutstandingExpectation();
        $httpBackend.verifyNoOutstandingRequest();
    });

    it("should handle API repsponse correctly", inject(function () {
        requestHandler.respond(200, Object({ DNA: "AAA", mRNA: "UUU", tRNA: "AAA", AminoAcids: ["Lysine"] }));

        index.dna = "AAA";
        index.decodeDNA();
        $httpBackend.flush();
        expect(index.mRNA).toEqual("UUU");
        expect(index.tRNA).toEqual("AAA");
        expect(index.aminoAcids).toEqual(["Lysine"]);

    }));

    it("should show the results only when they exist", inject(function () {
        requestHandler.respond(200, Object({ DNA: "AAA", mRNA: "UUU", tRNA: "AAA", AminoAcids: ["Lysine"] }));

        expect(index.showResults).toBeUndefined();

        index.dna = "AAA";
        index.decodeDNA();
        $httpBackend.flush();

        expect(index.showResults).toEqual(true);
    }));

    it("should tell the user when the string entered is invalid", inject(function () {
        requestHandler.respond(200, Object({ Error: "The DNA provided is not valid." }));

        expect(index.error).toBeUndefined();
        expect(index.errorMessage).toBeUndefined();

        index.dna = "AA";
        index.decodeDNA();
        $httpBackend.flush();

        expect(index.error).toEqual(true);
        expect(index.errorMessage).toEqual("The DNA provided is not valid.");
    }));
});
