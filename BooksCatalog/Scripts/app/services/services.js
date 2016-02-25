var booksServices = angular.module('booksServices', []);

booksServices.factory('crudService', ['$http', '$location', function ($http, $location) {
    var factory = {};

    factory.getBooks = function (callback) {
        $http.get("/bookscatalog/api/books").then(function(response) {
            callback(response.data);
        });
    };

    factory.getAuthors = function (callback) {
        $http.get("/bookscatalog/api/authors").then(function(response) {
            callback(response.data);
        });
    };

    factory.getGenres = function (callback) {
        $http.get("/bookscatalog/api/genres").then(function(response) {
            callback(response.data);
        });
    };

    factory.saveBook = function (book) {
        $http.post("/bookscatalog/api/books",
        {
            "name": book.name,
            "authorId": book.authorId,
            "genreId": book.genreId
        }).then(function () {
            $location.path('BooksCatalog/Scripts/app/partials/BooksList.html');
        });
    };

    return factory;
}]);