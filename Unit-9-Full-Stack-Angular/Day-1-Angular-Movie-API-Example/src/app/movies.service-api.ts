/***************************************************************
 This is service

 A service is a set of processing to facilitate the retrieval
 and storage of data - typically in a persistent source (saved)

 May do other processing as well

 This service DOES not save the data to a persistent source

 The data from this service is just an array in memory

*******************************************************************/

import { Injectable}   from '@angular/core'; // Access Angular Dependency Injection
import { MoviesInfo }  from './moviesInfo';  // Using the MoviesInfo interface
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { lastValueFrom } from 'rxjs';

// @Injectable tells Angular that this service may be Dependency Injection
@Injectable({
  providedIn: 'root'
})

export class MoviesService {

  private theServerURL: string = "https://localhost:7223/api/MovieApi/movies"

  // A module contains data and methods/functions for processing that data

  // Source of data for calls to retrieve the data - initialized in the code
  private listOfMovies : any[] = []  // An array of MovieInfo objects

  // a constructor is method to initialized data defined in the module
  // it is executed automatically when the service is loaded
  // Here we use the constructor to initialize our data source
  constructor(private  theServer: HttpClient) { 
    
  }

  // methods others may use to interact with our service

  // This method will return the current data in our data source (listOfMovies)
  //  name(parameters) : return-type-of-data-returned
      async getMoviesList()  : Promise<MoviesInfo[]> {  // this function returns a MoviesInfo array
        const theMovies: any[] = await lastValueFrom(this.theServer.get<any>(this.theServerURL))
        //deprecated this.http.get<any>(this.movieInfoApi).toPromise() 

        this.listOfMovies = theMovies

        return this.listOfMovies 
      }
  // This method will receive a MoviesInfo object and add it to our data source (listOfMovies)
      async addMovies(newMovie : any): Promise<any> {      
        const headers = new HttpHeaders ({
          'Content-Type' : 'application/json'
        });
         
// use http.post(API-URL, data-to-send, {header-object}).toPromise()                                
          return this.theServer.post(this.theServerURL, newMovie, {headers}).toPromise();
      }
    
}
