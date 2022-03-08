const Endpoints = {
    authorize: 'api/authorize',
    me: 'api/authorize/me',
    
    product: '/api/product',
    productID: (id) => `api/product/${id}`,

};

export default Endpoints;
