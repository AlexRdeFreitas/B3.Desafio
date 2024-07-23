import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { InvestmentService, InvestmentResponse } from '../investment.service';

@Component({
  selector: 'app-investment-form',
  templateUrl: './investment-form.component.html',
  styleUrls: ['./investment-form.component.css']
})
export class B3CdbFormComponent {
  investmentForm: FormGroup;
  investmentResult: InvestmentResponse | null = null;

  constructor(private fb: FormBuilder, private investmentService: InvestmentService) {
    this.investmentForm = this.fb.group({
      initialValue: [null, [Validators.required, Validators.min(0.01)]],
      months: [null, [Validators.required, Validators.min(2)]]
    });
  }

  onSubmit(): void {
    const { initialValue, months } = this.investmentForm.value;
    this.investmentService.calculateInvestment(initialValue, months).subscribe(result => {
      this.investmentResult = result;
    });
  }
}
