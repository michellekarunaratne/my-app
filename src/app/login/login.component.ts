import { Component, OnInit } from '@angular/core';
import { Router }  from '@angular/router';
import { NavService} from '../nav.service'

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  constructor(
    private router: Router,
    public nav:NavService

  ) {}

  ngOnInit() {
    this.nav.hide()
  }

  onButtonClick(){
    this.router.navigate(['/menu'])
  }

}
