import { CommonModule, NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { throwError } from 'rxjs';

@Component({
  selector: 'form-example',  // Name used in html to reference the component <form-example>
  standalone: true,
  imports: [FormsModule, CommonModule],  // Tell Angular we want Forms support for this code
  templateUrl: './form-example.component.html',
  styleUrl: './form-example.component.css'
})
// Allow access to stuff defined this component from outside the component
export class FormExampleComponent {
  firstName = ""
  lastName = ""
  birthDate = ""
  foodPref = ""
  email = ""
  emailPref = ""

  checkboxes: any[] = [
    {name: 'American Football', value: "Football"},
    {name: 'European Football', value: "Soccer"},
    {name: 'Baseball', value: "Baseball"},
    {name: 'Basketball', value: "Basketball"},
    {name: 'Hockey', value: "Hockey"},
    {name: 'Cricket', value: "Cricket"},
    {name: 'Other Sport', value: "Other"},
    {name: 'None', value: "None"}
  ]

  onSubmit() { // Handle the Submit button click on the  form
    console.log(`First Name ${this.firstName}`)
    console.log(`Last Name ${this.lastName}`)
    console.log(`Birth Date ${this.birthDate}`)
    console.log(`Food Preference ${this.foodPref}`)
    console.log(`Email ${this.email}`)
    console.log(`Ok to email ${this.emailPref}`)
    console.log(`Sports they like: `)
    // console.table(this.checkBoxResult)
    this.checkBoxResult.forEach(element => {
      console.log(element.name)
      
    });
  }
  
  get checkBoxResult(){  
    return this.checkboxes.filter(aCheckbox => aCheckbox.isChecked)
  }

  checkAllOptions(){
    if(this.checkboxes.every((aCheckbbox) => aCheckbbox.isChecked == true)){
      this.checkboxes.forEach(anElement => {anElement.isChecked = false});
    }
    else{
      this.checkboxes.forEach(anElement => {anElement.isChecked = true});
    }
  }
}