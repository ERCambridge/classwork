import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { StudentListComponent } from './student-list/student-list.component';
import { SampleFormComponent } from './sample-form/sample-form.component';

export const routes: Routes = [  
    { path: '', redirectTo: '/home', pathMatch: 'full' }, 
    { path: 'home', component: HomeComponent }, 
    { path: 'students', component: StudentListComponent }, 
    { path: 'contactInfo', component: SampleFormComponent }]
