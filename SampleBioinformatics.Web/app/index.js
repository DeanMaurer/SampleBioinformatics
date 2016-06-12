(function () {
    angular.module("bio").controller("index", index)

    index.$inject = ["$state", "$http"];
    function index($state, $http) {
        var self = this;
        var http = $http;
        self.showResults = false;
        self.error = false;

        self.decodeDNA = function () {
            http.get("/api/SampleBioinformatics/GetDNADecoded?DNA=" + self.dna).then(
                function (answer) {
                    self.mRNA = answer.data.mRNA;
                    self.tRNA = answer.data.tRNA;
                    self.aminoAcids = answer.data.AminoAcids;
                    self.showResults = true;
                },
                function () {
                    self.error = true;
                });
        };
    }
}());