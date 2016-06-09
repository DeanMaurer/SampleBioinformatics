(function () {
    angular.module("bio").config(config);

    config.$inject = ["$stateProvider", "$urlRouterProvider", "$locationProvider"];
    function config($stateProvider, $urlRouterProvider, $locationProvider) {
        $locationProvider.html5Mode({
            enabled: true,
            requireBase: false
        });
        $urlRouterProvider.otherwise("/");

        $stateProvider.state("bio", {
            url: "/",
            controller: "index",
            templateUrl: "/app/templates/_index.html"
        });
    }
}());