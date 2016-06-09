(function () {
    angular.module("bio").run(run);

    run.$inject = ["$rootScope", "$state", "$stateParams", "$window"];
    function run($rootScope, $state, $stateParams, $window) {
        $rootScope.$state = $state;
        $rootScope.$stateParams = $stateParams;
    }
}());