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

booksController.controller('BookCreateCtrl', ['$scope', '$http',
    function($scope, $http) {
        $http.get("/bookscatalog/api/authors").success(function (data) {
            $scope.authors = data;
        });

        $http.get("/bookscatalog/api/genres").success(function (data) {
            $scope.genres = data;
        });

        $scope.save = function(newBook) {
            $http.post("/bookscatalog/api/books", {"name": newBook.name, "authorId": newBook.authorId, "genreId": newBook.genreId});
        };
    }
]);