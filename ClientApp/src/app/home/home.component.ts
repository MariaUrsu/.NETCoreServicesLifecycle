import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public operationsFirst: any;
  public operationsSecond: any;

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    http.get<any>(baseUrl + 'operations').subscribe(result => {
      // this.operationsFirst = result;
    }, error => console.error(error));
  }

  getDataSecondRequest() {
    this.http.get<any>(this.baseUrl + 'operations').subscribe(result => {
     // this.operationsSecond = result;
    }, error => console.error(error));
  }
}
