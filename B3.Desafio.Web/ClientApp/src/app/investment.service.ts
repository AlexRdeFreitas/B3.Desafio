import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class InvestmentService {

  private apiUrl = 'https://localhost:7102/api/B3Cdb/calculate'; // URL da API .NET Core

  constructor(private http: HttpClient) { }

  calculateInvestment(amount: number, months: number): Observable<InvestmentResponse> {
    const body = { amount, months };
    return this.http.post<InvestmentResponse>(this.apiUrl, body);
  }
}

export interface InvestmentResponse {
  grossInvestment: number;
  netInvestment: number;
}
