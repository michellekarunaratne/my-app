import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class NavService {

  visibility:Boolean;

  constructor() { this.visibility=false }

  hide() { this.visibility = false; }

  show() { this.visibility = true; }

  toggle() { this.visibility = !this.visibility; }
}
