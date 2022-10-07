import { Asset, AssetArray, AssetResult } from '../../_interfaces/asset.model';
import { AssetsService } from '../../shared/services/assets.service';
import { Component, OnInit } from '@angular/core';
import { HttpErrorResponse } from '@angular/common/http';
import { Router } from '@angular/router';
import { AuthenticationService } from '../../shared/services/authentication.service';

@Component({
  selector: 'app-assets',
  templateUrl: './assets.component.html',
  styleUrls: ['./assets.component.css']
})
export class AssetsComponent implements OnInit {
  isUserAuthenticated: boolean;
  public assets: Asset[];
  currentAsset: Asset;
  public showSummary: boolean;

  constructor(private repository: AssetsService, private authService: AuthenticationService, private router: Router) { }

  ngOnInit(): void {
    this.authService.authChanged
    .subscribe(res => {
      console.log(res);
      this.isUserAuthenticated = res;
    })

    if(!this.isUserAuthenticated) {
      this.router.navigate(["/authentication/login"]);
    } else {
      this.getAssets();
    }
    this.showSummary = false;
    
  }

  onOptionSelected = (id: string) => {
    this.repository.getAssetById(id)
    .subscribe({
      next: (ass: AssetResult) => this.currentAsset = ass.data.asset,
      error: (err: HttpErrorResponse) => console.log(err)
    })
    console.log(JSON.stringify(this.currentAsset));
    this.showSummary = true;
  }

  getAssets = () => {
    this.repository.getSomeAssets()
    .subscribe({
      next: (ass: AssetArray) => this.assets = ass.data.assets,
      error: (err: HttpErrorResponse) => console.log(err)
    })
  }
}
