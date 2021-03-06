﻿using System.Threading.Tasks;
using ScryfallApi.Client.Models;

namespace ScryfallApi.Client.Apis
{
    public interface ISets
    {
        /// <summary>
        /// Returns a List object of all Sets on Scryfall.
        /// </summary>
        /// <returns></returns>
        Task<ResultList<Set>> Get();

        /// <summary>
        /// Returns a Set with the given set code. The code can be either the code or the mtgo_code for the set.
        /// </summary>
        /// <param name="setCode"></param>
        /// <returns></returns>
        Task<Set> Get(string setCode);
    }
}