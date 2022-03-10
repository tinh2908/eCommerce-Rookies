import { 
    NormalProductType,
    LuxuryProductType,
    NormalProductCategory,
    LuxuryProductCategory,
    AllProductType,
    NormalProductTypeLabel,
    LuxuryProductTypeLabel,
    NormalProductCategoryLabel,
    LuxuryProductCategoryLabel,
    AllProductTypeLabel
} from "./Product/ProductConstants";

export const ProductTypeOptions = [
    { id: 1, label: NormalProductTypeLabel, value: NormalProductType },
    { id: 2, label: LuxuryProductTypeLabel, value: LuxuryProductType },
];

export const ProductCategoryOptions = [
    { id: 1, label: NormalProductCategoryLabel, value: NormalProductCategory },
    { id: 2, label: LuxuryProductCategoryLabel, value: LuxuryProductCategory },
];

export const FilterProductTypeOptions = [
    { id: 1, label: AllProductTypeLabel, value: AllProductType },
    { id: 2, label: NormalProductTypeLabel, value: NormalProductType },
    { id: 3, label: LuxuryProductTypeLabel, value: LuxuryProductType },
];
