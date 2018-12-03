import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
//import { interval } from 'rxjs';
import { switchMap, map } from 'rxjs/operators';
import { Observable } from "rxjs";
import { Response, RequestOptions } from '@angular/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})

export class FetchDataComponent {
  batch: number = 2; //set default value
  processNumbers: number = 3;
  public getNumbers: BatchProcess[];
  multipliedNos: any;
  public tomultiply: MultiplyNumbers[];
  public multiplied: MultipleResult[];
  public remainingBatch: number;
  public generateResult: GenerateResult[];
  
  baseURL: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;
  }

  public StartProcess() {
    this.doProcess();
  }

  //getData(baseUrl: string): Observable<GenerateResult[]> {
    
  //  return this.http.get<GenerateResult[]>(baseUrl + 'api/SampleData/GenerateNumbers')
  //    .pipe(map(response => response));
  //}

  public doProcess() {

    this.http.get<GenerateResult[]>(this.baseURL + 'api/Process/GenerateNumbers?batch=' + this.batch + "&processNumbers=" + this.processNumbers).subscribe(async res => {

      this.generateResult = res;

      for (var i = 0; i < res.length; i++) {
        this.remainingBatch = res.length - 1;

        await this.http.get<MultipleResult[]>(this.baseURL + 'api/Process/MultipliedNumbers?multiplyNos=' + JSON.stringify(res[i].randomResult)).subscribe(async res => {
          this.multiplied = res;
          console.log(this.multiplied);

        });
      }
      });
  }

}

interface BatchProcess {
  multiplyResult: number;
}


interface MultiplyNumbers {
  multiplyResult: number;
}


interface MultipleResult {
  toMultiply: number;
  multipliedResult: number;
}


interface GenerateResult {
  Id: number; 
  randomResult: any;
}
