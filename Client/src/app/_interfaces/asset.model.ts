export interface AssetArray {
    data: AssetsData;
}

export interface AssetsData {
    assets: Asset[];
}

export interface AssetResult {
    data: AssetData;
}

export interface AssetData {
    asset: Asset;
}

export interface Asset {
    assetId: string;
    name: string;
    description: string;
    price: number;
    last24h: number;
    last7d: number;
}