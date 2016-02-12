var booksController = new angular.module('booksController', []);

booksController.controller('BookListCtrl', ['$scope', '$http',
    function ($scope, $http) {
        $scope.title = "Prived Medved";
        $http.get("/bookscatalog/api/books").success(function (data) {
            $scope.books = data;
        }).error(function(data) {
            $scope.title = "Something went wrong...";
        });
    }
]);