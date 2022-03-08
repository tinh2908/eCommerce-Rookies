import { AxiosResponse } from "axios";
import qs from 'qs';

import RequestService from '../../../services/request';
import EndPoints from '../../../Constants/endpoints';

export function createProductRequest(productForm) {
    const formData = new FormData();

    Object.keys(productForm).forEach(key => {
        formData.append(key, productForm[key]);
    });

    return RequestService.axios.post(EndPoints.product, formData);
}

export function getProductRequest(query) {
    return RequestService.axios.get(EndPoints.product, {
        params: query,
        paramsSerializer: params => qs.stringify(params),
    });
}

export function UpdateProductRequest(productForm) {
    const formData = new FormData();

    Object.keys(productForm).forEach(key => {
        formData.append(key, productForm[key]);
    });

    return RequestService.axios.put(EndPoints.productID(productForm.id ?? - 1), formData);
}

export function DisableProductRequest(productID) {
    return RequestService.axios.delete(EndPoints.productID(productID));
}