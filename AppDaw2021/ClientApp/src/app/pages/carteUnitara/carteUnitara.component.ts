import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CarteUnitaraService } from './carteUnitara.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-carteUnitara',
  templateUrl: './carteUnitara.component.html'
})
export class CarteUnitaraComponent implements OnInit {

  carte: Carte;

  constructor(private carteUnitaraService: CarteUnitaraService, private route: ActivatedRoute) { }
   ngOnInit(): void {
    this.route.params.subscribe(params => {
      const id = params['id'];
      this.carteUnitaraService.getCarte(id).subscribe(carte => this.carte = carte);
    })
    

  }

}

interface Carte {
  idCarte: string;
  numeCarte: string;
  descriere: string;
}

