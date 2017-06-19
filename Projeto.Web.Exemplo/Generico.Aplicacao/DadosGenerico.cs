using Generico.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico.Aplicacao
{
    public class DadosGenerico :CreateDatabaseIfNotExists<GenericoAplicacao>
    {
        protected override void Seed(GenericoAplicacao contexto)
        {
            List<TB_GENERO> generos = new List<TB_GENERO>()
            {
                new TB_GENERO() { Nome = "Administração" },
                new TB_GENERO() { Nome = "Agropecuária" },
                new TB_GENERO() { Nome = "Artes" },
                new TB_GENERO() { Nome = "Autoajuda" },
                new TB_GENERO() { Nome = "Ciências Biológicas" },
                new TB_GENERO() { Nome = "Ciências Exatas" },
                new TB_GENERO() { Nome = "Ciências Humanas e Sociais" },
                new TB_GENERO() { Nome = "Cursos e Idiomas" },
                new TB_GENERO() { Nome = "Didáticos" },
                new TB_GENERO() { Nome = "Direito" },
                new TB_GENERO() { Nome = "Economia" },
                new TB_GENERO() { Nome = "Engenharia e Tecnologia" },
                new TB_GENERO() { Nome = "Gastronomia" },
                new TB_GENERO() { Nome = "Geografia e Historia" },
                new TB_GENERO() { Nome = "Informática" },
                new TB_GENERO() { Nome = "Linguística" },
                new TB_GENERO() { Nome = "Literatura Nacional" },
                new TB_GENERO() { Nome = "Medicina" },
                new TB_GENERO() { Nome = "Religião" },
                new TB_GENERO() { Nome = "Turismo" },
            };

            generos.ForEach(g => contexto.genero.Add(g));

            List<TB_LIVRO> livros = new List<TB_LIVRO>()
            {
                new TB_LIVRO() {
                            Titulo = "O Poder do Hábito - Por Que Fazemos o Que Fazemos na Vida e Nos Negócios",
                            Autor = "Duhigg, Charles",
                            AnoEdicao = 2012,
                            Valor = 40.00m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Administração")
                },
                new TB_LIVRO() {
                            Titulo = "Os Segredos da Mente Milionária - Aprenda a Enriquecer Mudando seus Conceitos Sobre o Dinheiro",
                            Autor = "Eker, T. Harv",
                            AnoEdicao = 1992,
                            Valor = 22.40m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Administração")
                },
                new TB_LIVRO() {
                            Titulo = "Adestramento Inteligente",
                            Autor = "Rossi, Alexandre",
                            AnoEdicao = 2015,
                            Valor = 20.80m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Agropecuária")
                },
                new TB_LIVRO() {
                            Titulo = "Aves Florestais do Brasil",
                            Autor = "Bini, Etson",
                            AnoEdicao = 2014,
                            Valor = 89.90m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Agropecuária")
                },
                new TB_LIVRO() {
                            Titulo = "Guerra Civil",
                            Autor = "McNiven, Steve; MILLAR, MARK",
                            AnoEdicao = 2010,
                            Valor = 48m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Artes")
                },
                new TB_LIVRO() {
                            Titulo = "Batman - A Morte da Família",
                            Autor = "Capullo, Greg; Snyder, Scott",
                            AnoEdicao = 2016,
                            Valor = 60.80m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Artes")
                },
                new TB_LIVRO() {
                            Titulo = "Manual de Sobrevivência do Adolescente",
                            Autor = "Loures, Camila",
                            AnoEdicao = 2016,
                            Valor = 19.90m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Autoajuda")
                },
                new TB_LIVRO() {
                            Titulo = "O Mapa da Felicidade - As Coordenadas Para Curar A Sua Vida e Nunca Mais Olhar Para Trás",
                            Autor = "Capelas, Heloísa",
                            AnoEdicao = 2014,
                            Valor = 23.90m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Autoajuda")
                },
                new TB_LIVRO() {
                            Titulo = "A Origem Das Espécies - Edição Ilustrada",
                            Autor = "Darwin, Charles",
                            AnoEdicao = 2014,
                            Valor = 71.90m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Ciências Biológicas")
                },
                new TB_LIVRO() {
                            Titulo = "A Sexta Extinção - Uma História Não Natural",
                            Autor = "Kolbert, Elizabeth",
                            AnoEdicao = 2015,
                            Valor = 17.00m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Ciências Biológicas")
                },
                new TB_LIVRO() {
                            Titulo = "Raciocínio Lógico Facilitado",
                            Autor = "Villar, Bruno",
                            AnoEdicao = 2016,
                            Valor = 134.10m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Ciências Exatas")
                },
                new TB_LIVRO() {
                            Titulo = "Cálculo",
                            Autor = "Stewart, James",
                            AnoEdicao = 2015,
                            Valor = 143.20m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Ciências Exatas")
                },
                new TB_LIVRO() {
                            Titulo = "Uma Breve História da Humanidad",
                            Autor = "Harari, Yuval Noah",
                            AnoEdicao = 2015,
                            Valor = 47.90m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Ciências Humanas e Sociais")
                },
                new TB_LIVRO() {
                            Titulo = "O Príncipe - Obra Completa",
                            Autor = "Maquiavel, Nicolau",
                            AnoEdicao = 2007,
                            Valor = 17.10m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Ciências Humanas e Sociais")
                },
                new TB_LIVRO() {
                            Titulo = "English Grammar In Use With Answers",
                            Autor = "Murphy, Raymond",
                            AnoEdicao = 2012,
                            Valor = 173.50m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Cursos e Idiomas")
                },
                new TB_LIVRO() {
                            Titulo = "Gramática Y Práctica de Español",
                            Autor = "Fanjul, AdrIan",
                            AnoEdicao = 2014,
                            Valor = 82.00m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Cursos e Idiomas")
                },
                new TB_LIVRO() {
                            Titulo = "Novíssima Gramática da Língua Portuguesa",
                            Autor = "Cegalla, Domingos Paschoal",
                            AnoEdicao = 2009,
                            Valor = 82.00m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Didáticos")
                },
                new TB_LIVRO() {
                            Titulo = "Química - Vol. Único",
                            Autor = "Usberco, Joao; Salvador, Edgard",
                            AnoEdicao = 2013,
                            Valor = 194.00m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Didáticos")
                },
                new TB_LIVRO() {
                            Titulo = "Direito Processual Civil Esquematizado",
                            Autor = "Gonçalves, Marcus Vinicius Rios; (Coord.), Pedro Lenza",
                            AnoEdicao = 2016,
                            Valor = 163.20m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Direito")
                },
                new TB_LIVRO() {
                            Titulo = "Direito Administrativo",
                            Autor = "Pietro, Maria Sylvia Zanella Di",
                            AnoEdicao = 2016,
                            Valor = 108.10m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Direito")
                },
                new TB_LIVRO() {
                            Titulo = "O Capital - No Século XXI",
                            Autor = "Piketty, Thomas",
                            AnoEdicao = 2014,
                            Valor = 34.20m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Economia")
                },
                new TB_LIVRO() {
                            Titulo = "Fundamentos de Economia",
                            Autor = "Vasconcellos, Marco Antonio S.; Garcia, Manuel E.",
                            AnoEdicao = 2014,
                            Valor = 68.10m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Economia")
                },
                new TB_LIVRO() {
                            Titulo = "Manual Do Mundo",
                            Autor = "Alfredo Luis Mateus; Ibere Thenorio",
                            AnoEdicao = 2014,
                            Valor = 39.70m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Engenharia e Tecnologia")
                },
                new TB_LIVRO() {
                            Titulo = "Ciência Engenharia de Materiais -Uma Introdução",
                            Autor = "Callister Jr., William D.",
                            AnoEdicao = 2012,
                            Valor = 223.80m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Engenharia e Tecnologia")
                },
                new TB_LIVRO() {
                            Titulo = "Bela Cozinha - As Receitas",
                            Autor = "Gil , Bela",
                            AnoEdicao = 2014,
                            Valor = 29.10m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Gastronomia")
                },
                new TB_LIVRO() {
                            Titulo = "Por Uma Vida Mais Doce",
                            Autor = "Noce, Danielle",
                            AnoEdicao = 2014,
                            Valor = 79.80m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Gastronomia")
                },
                new TB_LIVRO() {
                            Titulo = "1808",
                            Autor = "Gomes, Laurentino",
                            AnoEdicao = 2014,
                            Valor = 31.90m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Geografia e Historia")
                },
                new TB_LIVRO() {
                            Titulo = "A História do Mundo Para Quem Tem Pressa -Mais de 5000 Anos de História Resumidos Em 200 Páginas",
                            Autor = "Marriot, Emma",
                            AnoEdicao = 2015,
                            Valor = 22.60m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Geografia e Historia")
                },
                new TB_LIVRO() {
                            Titulo = "Redes de Computadores",
                            Autor = "Tanenbaum, Andrew S.; J.Wetherall, David",
                            AnoEdicao = 2011,
                            Valor = 166.40m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Informática")
                },
                new TB_LIVRO() {
                            Titulo = "Lógica de Programação - Conhecendo Algoritmos e Criando Programas",
                            Autor = "Simão , Daniel Hayashida; Reis , Wellington José Dos",
                            AnoEdicao = 2015,
                            Valor = 26.40m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Informática")
                },
                new TB_LIVRO() {
                            Titulo = "Mídia Training - Como Usar A Mídia A Seu Favor",
                            Autor = "Barbeiro, Herodoto",
                            AnoEdicao = 2015,
                            Valor = 25.30m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Linguística")
                },
                new TB_LIVRO() {
                            Titulo = "Anatomia de Um Julgamento - Ifigênia Em Forest Hills",
                            Autor = "Malcolm, Janet",
                            AnoEdicao = 2012,
                            Valor = 22.40m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Linguística")
                },
                new TB_LIVRO() {
                            Titulo = "Tratado de Medicina Interna Veterinária - Doenças do Cão e do Gato",
                            Autor = "Ettinger, Stephen J.; Feldman, Edward C.",
                            AnoEdicao = 2004,
                            Valor = 1309.50m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Medicina")
                },
                new TB_LIVRO() {
                            Titulo = "Clínica Veterinária - Um Tratado de Doenças dos Bovinos, Ovinos, Suínos, Caprinos e Equinos",
                            Autor = "Outros; Blood, Douglas C.; Radostits, Otto M.",
                            AnoEdicao = 2002,
                            Valor = 1080.00m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Medicina")
                },
                new TB_LIVRO() {
                            Titulo = "Quarto de Guerra - A Oração É Uma Arma Poderosa na Batalha Espiritual",
                            Autor = "Fabry, Chris",
                            AnoEdicao = 2015,
                            Valor = 25.50m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Religião")
                },
                new TB_LIVRO() {
                            Titulo = "Cristianismo Puro e Simples",
                            Autor = "Lewis, C. S.",
                            AnoEdicao = 2009,
                            Valor = 36.00m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Religião")
                },
                new TB_LIVRO() {
                            Titulo = "Não Conta Lá Em Casa",
                            Autor = "Fran, André",
                            AnoEdicao = 2013,
                            Valor = 56.60m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Turismo")
                },
                new TB_LIVRO() {
                            Titulo = "O Melhor Guia de Nova York",
                            Autor = "Andrade, Pedro",
                            AnoEdicao = 2013,
                            Valor = 29.30m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Turismo")
                }
            };

            livros.ForEach(l => contexto.livro.Add(l));

            contexto.SaveChanges();
        }
    }
}