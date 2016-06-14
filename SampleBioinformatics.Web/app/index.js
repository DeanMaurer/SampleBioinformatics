(function () {
    angular.module("bio").controller("index", index)

    index.$inject = ["$state", "$http"];
    function index($state, $http) {
        var self = this;
        var http = $http;

        self.decodeDNA = function () {
            http.get("/api/SampleBioinformatics/GetDNADecoded?DNA=" + self.dna).then(
                function (answer) {
                    parseSuccess(answer.data);
                },
                function () {
                    self.error = true;
                    self.errorMessage = "Problems!";
                });
        };

        parseSuccess = function (results) {
            if (results.Error) {
                self.error = true;
                self.errorMessage = results.Error;
                self.showResults = false;
            }
            else {
                self.mRNA = results.mRNA;
                self.tRNA = results.tRNA;
                self.aminoAcids = results.AminoAcids;
                self.showResults = true;
                self.error = false;
            }
        };
    }
}());