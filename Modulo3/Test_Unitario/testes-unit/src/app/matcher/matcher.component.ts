import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-matcher',
  templateUrl: './matcher.component.html',
  styleUrls: ['./matcher.component.css']
})
export class MatcherComponent implements OnInit {
  
  constructor() { }

  ngOnInit(): void {
  }

  igual(): number{
    return 2
  }
  frutas(): string[]{
    return ["maçã", "perâ", "uva"]
  }

}
