// typescript file goes here
console.log("Welcome to TypeScript");
var Roster = /** @class */ (function () {
    function Roster() {
        this.studentRoster = [];
    }
    Roster.prototype.addStudent = function (aStudent) {
        this.studentRoster.push(aStudent);
    };
    Roster.prototype.getStudents = function () {
        return this.studentRoster;
    };
    Roster.prototype.findStudent = function (aName) {
        var indexOfFoundElement = this.studentRoster.findIndex(function (theElement) {
            return theElement.firstName == aName;
        });
        if (indexOfFoundElement > -1) {
            return this.studentRoster[indexOfFoundElement];
        }
        return null;
    };
    Roster.prototype.removeStudent = function (theName) {
        var indexOfFoundElement = this.studentRoster.findIndex(function (theElement) {
            return theElement.firstName == theName;
        });
        if (indexOfFoundElement > -1) {
            this.studentRoster.splice(indexOfFoundElement, 1);
            return true;
        }
        return false;
    };
    Roster.prototype.sortRoster = function () {
        this.studentRoster.sort(function (firstElement, secondElement) {
            if (firstElement.firstName < secondElement.firstName) {
                return -1;
            }
            if (firstElement.firstName > secondElement.firstName) {
                return 1;
            }
            return 0;
        });
    };
    return Roster;
}());
var aRoster = new Roster();
var aStudent = { firstName: "Frank", class: "Welding", startDate: 20250214 };
aRoster.addStudent(aStudent);
aRoster.addStudent({ firstName: "Josh", class: "Programming", startDate: 20240801 });
aRoster.addStudent({ firstName: "Evan", class: "Programming", startDate: 20240801 });
aRoster.addStudent({ firstName: "Ethan", class: "C#", startDate: 20240801 });
aRoster.addStudent({ firstName: "Ryan", class: "HTML", startDate: 20240801 });
aRoster.addStudent({ firstName: "Kendall", class: "Angular", startDate: 20240801 });
aRoster.getStudents().forEach(function (aStudent) {
    console.table(aStudent);
});
console.log("--- Finding elements ---");
console.log(aRoster.findStudent("Evan"));
console.log(aRoster.findStudent("Bob"));
console.log("--- Removing the frank element ---");
console.log("Was Frank removed: ".concat(aRoster.removeStudent("Frank")));
console.log("Was Frank removed: ".concat(aRoster.removeStudent("Frank")));
console.log("--- Sorting array ---");
aRoster.sortRoster();
aRoster.getStudents().forEach(function (aStudent) {
    console.table(aStudent);
});
