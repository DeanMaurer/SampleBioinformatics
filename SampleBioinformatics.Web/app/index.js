(function () {
    angular.module("bio").controller("index", index)

    index.$inject = ["$state", "$http"];
    function index($state, $http) {
        var self = this;
        var http = $http;

        self.decodeDNA = function () {
            http.get("/api/SampleBioinformatics/GetDNADecoded?DNA=" + self.dna).then(
                function (answer) {
                    self.decodedInfo = answer.data;
                    self.mRNA = answer.data.mRNA;
                    self.tRNA = answer.data.tRNA;
                    self.aminoAcids = answer.data.AminoAcids;
                },
                function () {
                    self.decodedInfo = "error"
                });
        };
    }
}());