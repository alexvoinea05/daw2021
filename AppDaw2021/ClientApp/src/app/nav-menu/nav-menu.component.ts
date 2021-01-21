import { Component, OnInit } from '@angular/core';
import { AccountService } from '../account/account.service';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit {
  model: any = {}
  loggedIn: boolean;
  isExpanded = false;

  constructor(private accountService: AccountService, private router: Router, private toastr: ToastrService) { }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  ngOnInit(): void {

  }

  login() {
    this.accountService.login(this.model).subscribe(response => {
      this.router.navigateByUrl('/api/categorie')
      this.loggedIn = true;
    }, error => {
        console.log(error);
        this.toastr.error(error.error);

    })
  }

  logout() {
    this.loggedIn = false;
    this.router.navigateByUrl('/');

  }
}
