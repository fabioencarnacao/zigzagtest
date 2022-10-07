import { AssetArray, AssetResult } from '../../_interfaces/asset.model';
import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http'; 
import { EnvironmentUrlService } from './environment-url.service';

@Injectable({
  providedIn: 'root'
})
export class AssetsService {

  constructor(private http: HttpClient, private envUrl: EnvironmentUrlService) { }
  

  public getSomeAssets = () => {
    var token = localStorage.getItem('token');
    
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type':  'application/json',
        'Authorization': 'Bearer ' + token
      })
    };

    const body = {
      query: `{
                assets {
                  assetId,
                  name
                }
              }`
    };

    return this.http.post<AssetArray>(this.envUrl.urlAddress+'/graphql', body, httpOptions);;
  }

  public getAssetById = (id: string) => {
    var token = localStorage.getItem('token');
    
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type':  'application/json',
        'Authorization': 'Bearer ' + token
      })
    };

    const body = {
      query: `{
                asset(id: "${id}") {
                  assetId,
                  name,
                  description,
                  price,
                  last24h,
                  last7d
                }
              }`
    };

    return this.http.post<AssetResult>(this.envUrl.urlAddress+'/graphql', body, httpOptions);
  }

}