import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-carte',
  templateUrl: './carte.component.html'
})
export class CarteComponent {
  public Carte: task[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<task[]>(baseUrl + 'api/carte').subscribe(result => {
      this.Carte = result;
    }, error => console.error(error));
  }
}

interface task {
  idCarte: string;
  numeCarte: string;
}


