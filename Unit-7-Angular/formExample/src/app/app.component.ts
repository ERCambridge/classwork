import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { FormExampleComponent } from "./components/form-example/form-example.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, FormExampleComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  pageHeading = 'Welcome to AHBC - C# - Contact Info Submission';
}
