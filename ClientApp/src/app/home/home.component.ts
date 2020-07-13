import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public firstOperations: Operation[];
  public secondOperations: Operation[];

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    http.get<Operation[]>(baseUrl + 'operations').subscribe(result => {
      this.firstOperations = result;
    }, error => console.error(error));
  }

  getDataSecondRequest() {
    this.http.get<Operation[]>(this.baseUrl + 'operations').subscribe(result => {
    this.secondOperations = result;
    }, error => console.error(error));
  }
}

interface Operation {
  name: string;
  operationId: string;
}
