﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAPI.Data;
using RestAPI.Data.Models;

namespace RestAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProduitsController : ControllerBase
	{
		public ProduitsController(AppDbContext db )
		{
		_db = db;
		
		
		}
		private readonly AppDbContext _db;

		[HttpGet]
		public async Task<IActionResult> GetProduits()
		{
			try
			{
				var prod = await _db.Produits.ToListAsync();
				return Ok(prod);
			}
            catch (InvalidCastException ex)
            {
                // Gérer l'erreur, par exemple en retournant un message clair
                return BadRequest("Erreur de conversion : " + ex.Message);
            }
            catch (Exception ex)
            {
                // Gérer les autres exceptions
                return StatusCode(500, "Erreur interne du serveur : " + ex.Message);
            }


        }
		[HttpPost]
		public async Task<IActionResult> AddProduit([FromBody] Produit produit)
		{
			Produit p = new() {
				CodeMonture = produit.CodeMonture,
				RefFms = produit.RefFms,
				PrixAchatHT = produit.PrixAchatHT,
				Taille = produit.Taille,
				Referance = produit.Referance,
				Fournisseur = produit.Fournisseur,
				Marque = produit.Marque,
				PrixVenteHT = produit.PrixVenteHT,
				Marge = produit.Marge,
				PrixVenteTTC = produit.PrixVenteTTC,
				Matiere = produit.Matiere,
				Code = produit.Code,
				TVA = produit.TVA,
				PrixAchatNetTTC = produit.PrixAchatNetTTC,
				Forme = produit.Forme

			};
			await _db.Produits.AddAsync(p);
			_db.SaveChanges();
			return Ok();
		}
		[HttpPut]
		public async Task<IActionResult> UpdateProduit( Produit produit)
		{
			var p = await _db.Produits.SingleOrDefaultAsync(x=> x.Id == produit.Id);
			if (p == null)
			{
				return NotFound($"Produit Id {produit.Id} not exists");

			}
			p.CodeMonture = produit.CodeMonture;
			p.RefFms = produit.RefFms;
			p.PrixAchatHT = produit.PrixAchatHT;
			p.Taille = produit.Taille;
			p.Referance = produit.Referance;
			p.Fournisseur = produit.Fournisseur;
			p.Marque = produit.Marque;
			p.PrixVenteHT = produit.PrixVenteHT;
			p.Marge = produit.Marge;
			p.PrixVenteTTC = produit.PrixVenteTTC;
			p.Matiere = produit.Matiere;
			p.Code = produit.Code;
			p.TVA = produit.TVA;
			p.PrixAchatNetTTC = produit.PrixAchatNetTTC;
			p.Forme = produit.Forme;
			_db.SaveChanges();
			return Ok(p);


		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> RemoveProduit(int id )
		{
			var p = await _db.Produits.SingleOrDefaultAsync(x=> x.Id == id);
			if (p == null)
			{
				return NotFound($"Produit Id {id} not exists ");
			}
			_db.Produits.Remove(p);
			_db.SaveChanges();
			return Ok(p);
		}



}
}
