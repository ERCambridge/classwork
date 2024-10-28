// typescript file goes here
console.log("Welcome to TypeScript")

interface Student{
    firstName: string;
    class: string;
    startDate: number; //yyyymmdd
}

class Roster{
    private studentRoster: Student[];

    constructor(){
        this.studentRoster =[];
    }

    addStudent(aStudent: Student): void{
        this.studentRoster.push(aStudent);
    }

    getStudents() : Student[]{
        return this.studentRoster;
    }

    findStudent(aName : String) : Student | null {
        let indexOfFoundElement : number = this.studentRoster.findIndex(theElement =>
            theElement.firstName == aName
        )
        if (indexOfFoundElement > -1){
            return this.studentRoster[indexOfFoundElement];
        }
        return null;
    }

    removeStudent(theName : string) : Boolean{
        let indexOfFoundElement : number = this.studentRoster.findIndex(theElement =>
            theElement.firstName == theName
        )
        if (indexOfFoundElement > -1){
            this.studentRoster.splice(indexOfFoundElement, 1);
            return true;
        }
        return false;
    }

    sortRoster() : void{
        this.studentRoster.sort((firstElement:Student, secondElement:Student) => {
        if(firstElement.firstName < secondElement.firstName){
            return -1
        }
        if(firstElement.firstName > secondElement.firstName){
            return 1
        }
        return 0
    })
    }
}


let aRoster = new Roster();
let aStudent : Student = {firstName: "Frank", class: "Welding", startDate : 20250214}

aRoster.addStudent(aStudent)
aRoster.addStudent({firstName : "Josh", class : "Programming", startDate : 20240801});
aRoster.addStudent({firstName : "Evan", class : "Programming", startDate : 20240801});
aRoster.addStudent({firstName : "Ethan", class : "C#", startDate : 20240801});
aRoster.addStudent({firstName : "Ryan", class : "HTML", startDate : 20240801});
aRoster.addStudent({firstName : "Kendall", class : "Angular", startDate : 20240801});

aRoster.getStudents().forEach(aStudent => {
    console.table(aStudent);
});

console.log(`--- Finding elements ---`)
console.log(aRoster.findStudent("Evan"));
console.log(aRoster.findStudent("Bob"));

console.log(`--- Removing the frank element ---`)

console.log(`Was Frank removed: ${aRoster.removeStudent("Frank")}`)
console.log(`Was Frank removed: ${aRoster.removeStudent("Frank")}`)

console.log(`--- Sorting array ---`)

aRoster.sortRoster();

aRoster.getStudents().forEach(aStudent => {
    console.table(aStudent);
});
