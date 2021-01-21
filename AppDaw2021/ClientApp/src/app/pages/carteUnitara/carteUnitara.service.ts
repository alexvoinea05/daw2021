import { HttpClient } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';
import { of } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { ActivatedRoute } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class CarteUnitaraService {
  //baseUrl = environment.apiEndpointUrl;
  constructor(private http: HttpClient, private route: ActivatedRoute) { }

  getCarte(id: string) {
    return this.http.get<any>("https://localhost:44334/api/carte/unitara/" + id);
  }
}
