'Use Strict'
var ctrlMod = angular.module('app.controllers');
// Path: /about
ctrlMod.controller('AboutCtrl', ['$scope', '$location', '$window', function ($scope, $location, $window) {
    $scope.$root.title = 'AngularJS SPA | About';
    $scope.test = "test 123";
    $scope.$on('$viewContentLoaded', function () {
        $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
    });
}])