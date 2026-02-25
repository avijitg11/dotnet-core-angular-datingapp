import { HttpClient } from '@angular/common/http';
import { Component, inject, OnInit, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App implements OnInit {  
  protected readonly title = signal('Dating.Ui');
  private http = inject(HttpClient);

  ngOnInit(): void {
    this.http.get("https://localhost:7065/api/Members").subscribe({
      next: response => console.log(response),
      error: error => console.log(error),
      complete: ()=> console.log("completed")
    });
  }
}
