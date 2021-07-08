import { Component, OnInit } from '@angular/core';
import * as fromServices from '../../services';
import * as fromModels from '../../models';

@Component({
  selector: 'app-matrix-board',
  templateUrl: './matrix-board.component.html',
  styleUrls: ['./matrix-board.component.scss']
})

export class MatrixBoardComponent implements OnInit {

  sounds: fromModels.ISound[] = [];
  Arr: Array<number> = [];
  counter: number = 25;

  constructor(private musicAPIService: fromServices.musicAPIService) { }

  ngOnInit(): void {
    this.Arr.fill(25);
    this.musicAPIService.getSounds().subscribe(results => (this.sounds = results));
  }

}
