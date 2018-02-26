// Built from tag v0.99.0

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Administrasjon.Organisasjon
{
	public class Organisasjonselement : Enhet {
		public enum Relasjonsnavn
        {
			LEDER,
			OVERORDNET,
			UNDERORDNET,
			SKOLE,
			ARBEIDSFORHOLD
        }
        
	
		public Periode Gyldighetsperiode { get; set; }
		public string Kortnavn { get; set; }
		public string Navn { get; set; }
		public Identifikator OrganisasjonsId { get; set; }
		public Identifikator OrganisasjonsKode { get; set; }
		
	}
}
