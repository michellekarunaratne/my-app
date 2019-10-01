import { Component, OnInit } from '@angular/core';
import { NavService } from '../nav.service'

@Component({
  selector: 'app-insert',
  templateUrl: './insert.component.html',
  styleUrls: ['./insert.component.scss']
})
export class InsertComponent implements OnInit {

  constructor(
    public nav:NavService
  ) { }

  ngOnInit() {
      this.nav.show()
  }

}
