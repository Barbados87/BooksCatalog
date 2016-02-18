var booksController = new angular.module('booksController', []);

booksController.controller('BookListCtrl', ['$scope', '$http', 'crudService',
    function ($scope, $http, crudService) {
        $scope.title = "Prived Medved";

        $scope.loadBooks = function() {
            $scope.books = crudService.loadBooks();
        };
        $scope.loadBooks();

        $http.get("/bookscatalog/api/authors").success(function (data) {
            $scope.authors = data;
        });

        $http.get("/bookscatalog/api/genres").success(function (data) {
            $scope.genres = data;
        });

        $scope.save = function() {
            crudService.saveBook($scope.newBook);
            $scope.newBook = {};
            $scope.loadBooks();
        };
    }
]);