namespace MoviesService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedCountiesTable : DbMigration
    {
        public override void Up()
        {
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13702, 'Alajuela', 843);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13703, 'Atenas', 843);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13704, 'Guatuso', 843);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13705, 'Poas', 843);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13706, 'San Carlos', 843);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13707, 'Valverde Vega', 843);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13712, 'Grecia', 843);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13715, 'Los Chiles', 843);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13717, 'Naranjo', 843);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13718, 'Orotina', 843);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13719, 'Palmares', 843);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13729, 'San Mateo', 843);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13732, 'San Ramon', 843);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13739, 'Upala', 843);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13741, 'Zarcero', 843);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13742, 'Cartago', 844);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13743, 'Paraiso', 844);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13744, 'La Unión', 844);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13745, 'Jimenez', 844);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13746, 'Turrialba', 844);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13747, 'Alvarado', 844);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13748, 'Oreamuno', 844);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13749, 'El Guarco', 844);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13768, 'Liberia', 845);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13769, 'Nicoya', 845);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13770, 'Santa Cruz', 845);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13771, 'Bagaces', 845);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13772, 'Carrillo', 845);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13773, 'Cañas', 845);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13774, 'Abangares', 845);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13775, 'Tilarán', 845);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13776, 'Nandayure', 845);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13777, 'La Cruz', 845);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13778, 'Hojancha', 845);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13787, 'Barva', 846);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13788, 'Belén', 846);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13789, 'Heredia', 846);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13790, 'Flores', 846);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13796, 'San Isidro', 846);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13802, 'San Pablo', 846);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13804, 'San Rafael', 846);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13807, 'Santa Bárbara', 846);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13811, 'Santo Domingo', 846);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13812, 'Sarapiquí', 846);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13814, 'Limon', 847);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13815, 'Pococi', 847)");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13816, 'Siquirres', 847);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13817, 'Talamanca', 847);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13818, 'Matina', 847);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13819, 'Guacimo', 847);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13828, 'Puntarenas', 848);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13829, 'Corredores', 848);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13830, 'Coto Brus', 848);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13831, 'Esparza', 848);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13832, 'Garabito', 848);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13833, 'Golfito', 848);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13834, 'Montes de Oro', 848);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13835, 'Osa', 848);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13836, 'Parrita', 848);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13837, 'Quepos', 848);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13838, 'Buenos Aires', 848);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13849, 'San José',849);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13850, 'Escazu',849);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13851,'Desamparados',849);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13852,'Puriscal',849);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13853,'Tarrazu', 849);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13854,'Aserrí', 849);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13855,'Mora',849);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13856,'Goicoechea',849);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13857,'Santa Ana', 849);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13858,'Alajuelita',849);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13859,'Vazquez de Coronado',849);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13860,'Acosta',849);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13861,'Tibas',849);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13862,'Moravia',849);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13863,'Montes de Oca',849);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13864,'Turrubares',849);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13865,'Dota',849);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13866,'Curridabat',849);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13867,'Perez Zeledón',849);");
			Sql("INSERT INTO Counties(Id, Name, ProvinceId) VALUES (13868,'Leon Cortes Castro',849);");
		}
        
        public override void Down()
        {
			Sql("DELETE FROM Counties");
        }
    }
}
