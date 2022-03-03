﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Rookies.ShareClassdLibrary.Dto.Category;

public interface ICategoryService
{
    Task<IList<CategoryDto>> GetCategoryAsync();

}