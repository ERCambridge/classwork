import { CommonModule }  from '@angular/common';
import { Component, OnInit }     from '@angular/core';
import { MoviesInfo }    from '../moviesInfo';            // access the MoviesList interface
import { MoviesService } from '../movies.service-api';// access the MoviesServices service
import { RouterLink }    from '@angular/router';

@Component({
  selector: 'app-movie-list',
  standalone: true,
  imports: [CommonModule, RouterLink],
  templateUrl: './movie-list.component.html',
  styleUrl: './movie-list.component.css'
})
export class MovieListComponent implements OnInit {

// This will hold the data for the movies to be displayed
// the data will come from a call to a service
// it starts out as an empty array  
//     var-name   : data-type - array of our interface
public moviesList : any[] = [] ; // This is an array of MoviesInfo objects

// constructor is used to initialize data in the component
//
// This style of constructor will define the variable, create a MoviesService object
//                                       and assign that object to the variable
//                                       using Dependency Injection (DI)
//
// Dependency Injection is the automatic creation of variables and objects required
// (instead of the programming having to instantiate objects it needs, its done automatically)
//
// Dependency Injection decouples the service from the code
// (makes it much easier to change the service)
//   
// without Dependency Injection the code would look like this:
//
//     private movieService;   // define a variable to hold the service
//
//     constructor() {
//                    movieService = new MoviesServices();// create the service
//                   }                                    //    and assign it to the variable
//

// The constructor for component is automatically run when the component is instantiated by Angular

//           this movieService object is automatically instantiated and passed to this constructor                           
constructor(private movieService  : MoviesService ) {} 

async ngOnInit() {
  // We have wait for the asynchronous process of retrieving the data before we gone
  const theData  = await this.movieService.getMoviesList(); // Initialize our moviesList from service
  // once the data comes back from the service, we can assign it to our array
  this.moviesList = theData

  //console.table(this.movieService) // optional - for testing and debugging only
}
}
