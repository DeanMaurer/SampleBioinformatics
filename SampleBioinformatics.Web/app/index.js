(function () {
    angular.module("bio").controller("index", index)

    index.$inject = ["$state", "$http"];
    function index($state, $http) {
        var self = this;
        var http = $http;
        self.response = "";
        self.decodedInfo = "";

        self.success = function () {
            http.get("/api/SampleBioinformatics/GetSuccess").then(
                function (answer) {
                    self.response = answer.data;
                },
                function () {
                    self.response = "error";
                });
        };

        self.decodeDNA = function () {
            http.get("/api/SampleBioinformatics/GetDNADecoded?DNA=" + self.dna).then(
                function (answer) {
                    self.decodedInfo = answer.data;
                },
                function () {
                    self.decodedInfo = "error"
                });
        };
    }
}());