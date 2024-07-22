import { Component, Input } from '@angular/core';
import { InvestmentResponse } from '../investment.service';

@Component({
  selector: 'app-investment-result',
  templateUrl: './investment-result.component.html',
  styleUrls: ['./investment-result.component.css']
})
export class B3CdbResultComponent {
  @Input() investmentResult: InvestmentResponse | null = null;
}
