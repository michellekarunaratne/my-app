import { Component, OnInit } from '@angular/core';
import { NavService } from '../nav.service'

@Component({
  selector: 'app-delete',
  templateUrl: './delete.component.html',
  styleUrls: ['./delete.component.scss']
})
export class DeleteComponent implements OnInit {

  constructor(
    public nav:NavService
  ) { }

  ngOnInit() {
    this.nav.show()
  }

}
