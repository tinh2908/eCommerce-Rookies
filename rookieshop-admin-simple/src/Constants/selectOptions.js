import { 
    NormalProductType, 
    LuxuryProductType,
    AllProductType,
    NormalProductTypeLabel,
    LuxyryProductTypeLabel,
    AllProductTypeLabel
} from "./Product/ProductConstants";

export const ProductTypeOptions = [
    { id: 1, label: NormalProductTypeLabel, value: NormalProductType },
    { id: 2, label: LuxyryProductTypeLabel, value: LuxuryProductType },
];

export const FilterProductTypeOptions = [
    { id: 1, label: AllProductTypeLabel, value: AllProductType },
    { id: 2, label: NormalProductTypeLabel, value: NormalProductType },
    { id: 3, label: LuxyryProductTypeLabel, value: LuxuryProductType },
];
