import React, { useEffect, useState } from "react";
import { FunnelFill } from "react-bootstrap-icons";
import { Search } from "react-feather";
import ReactMultiSelectCheckboxes from "react-multiselect-checkboxes";

import { Link } from "react-router-dom";
import ProductTable from "./ProductTable";

import { FilterProductTypeOptions } from "../../../Constants/selectOptions";
import { getProductRequest } from "../services/request"
import { 
  ACCSENDING, 
  DECSENDING, 
  DEFAULT_PRODUCT_SORT_COLUMN_NAME,
  DEFAULT_PAGE_LIMIT
} from "../../../Constants/paging"

const ListProduct = () => {
  const [query, setQuery] = useState({
    page: 1,
    limit: DEFAULT_PAGE_LIMIT,
    sortOrder: DECSENDING,
    sortColumn: DEFAULT_PRODUCT_SORT_COLUMN_NAME
  });

  const [search, setSearch] = useState("");
  const [product, setProduct] = useState("");

  const [selectedType, setSelectedType] = useState([
    { id: 1, label: "All", value: 0 },
  ]);

  const handleType = (selected) => {
    if (selected.length === 0) {
      setQuery({
        ...query,
        types: [],
      });

      setSelectedType([FilterProductTypeOptions[0]]);
      return;
    }

    const selectedAll = selected.find((item) => item.id === 1);

    setSelectedType((prevSelected) => {
      if (!prevSelected.some((item) => item.id === 1) && selectedAll) {
        setQuery({
          ...query,
          types: [],
        });

        return [selectedAll];
      }

      const newSelected = selected.filter((item) => item.id !== 1);
      const types = newSelected.map((item) => item.value);

      setQuery({
        ...query,
        types,
      });

      return newSelected;
    });
  };

  const handleChangeSearch = (e) => {
    e.preventDefault();

    const search = e.target.value;
    setSearch(search);
  };

  const handlePage = (page) => {
    setQuery({
      ...query,
      page,
    });
  };

  const handleSearch = () => {
    setQuery({
      ...query,
      search,
    });
  };

  const handleSort = (sortColumn) => {
    const sortOrder = query.sortOrder === ACCSENDING ? DECSENDING : ACCSENDING;

    setQuery({
      ...query,
      sortColumn,
      sortOrder,
    });
  };

  const fetchDataCallbackAsync = async () =>  {
    let data = await getProductRequest(query);
    console.log('fetchDataCallbackAsync');
    console.log(data);
    setProduct(data);
  }

  useEffect(() => {
    async function fetchDataAsync() {
      let result = await getProductRequest(query);
      setProduct(result.data);
    }

    fetchDataAsync();
  }, [query]);

  return (
    <>
      <div className="primaryColor text-title intro-x">Product List</div>

      <div>
        <div className="d-flex mb-5 intro-x">
          <div className="d-flex align-items-center w-md mr-5">
          <ReactMultiSelectCheckboxes
              options={FilterProductTypeOptions}
              hideSearch={true}
              placeholderButtonLabel="Type"
              value={selectedType}
              onChange={handleType}
            />

            <div className="border p-2">
              <FunnelFill />
            </div>
          </div>

          <div className="d-flex align-items-center w-ld ml-auto">
            <div className="input-group">
              <input
                onChange={handleChangeSearch}
                value={search}
                type="text"
                className="form-control"
              />
              <span onClick={handleSearch} className="border p-2 pointer">
                <Search />
              </span>
            </div>
          </div>

          <div className="d-flex align-items-center ml-3">
            <Link to="/product/create" type="button" className="btn btn-info">
              Create new Product
            </Link>
          </div>
        </div>

        <ProductTable
          products={product}
          handlePage={handlePage}
          handleSort={handleSort}
          sortState={{
            columnValue: query.sortColumn,
            orderBy: query.sortOrder,
          }}
          fetchData={fetchDataCallbackAsync}
        />
      </div>
    </>
  );
};

export default ListProduct;
