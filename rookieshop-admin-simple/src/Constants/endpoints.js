const Endpoints = {
    authorize: 'api/authorize',
    me: 'api/authorize/me',
    
    product: '/api/product',
    productID: (id) => `api/product/${id}`,

    category: '/api/category',
    categoryID: (id) => `api/category/${id}`,

};

export default Endpoints;
