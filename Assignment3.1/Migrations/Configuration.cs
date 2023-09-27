namespace Assignment3._1.Migrations
{
    using Assignment3.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;


    internal sealed class Configuration : DbMigrationsConfiguration<Assignment3._1.Data.Assignment3_1Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Assignment3._1.Data.Assignment3_1Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var categories = new List<Category>
             {
                new Category {Type = "Oily Hair" },
                new Category {Type = "Dry Hair" },
                new Category {Type = "Fine Hair" },
                new Category {Type = "Thick Hair" },
                new Category {Type = "Curly Hair" },
                new Category {Type = "Damaged Hair" },
                new Category {Type = "Straight Hair" }
             };
            //Update categories if one with same type doesnt already exist in db.
            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Type, c));
            context.SaveChanges();

            var products = new List<Product>
            {
                //OILY HAIR
                new Product{Name = "Sunday Shampoo", Brand = "Bumble and Bumble",
                Description = "To be used once a week, this detoxing shampoo will blitz your locks of ALL build up (from pollutants to excess oil, and hard water to styling " +
                "products) leaving it feeling light and clean. If your hair is coloured or chemically " +
                "treated approach this one with care though, as it can be a little intense for fragile locks.",
                Price = 51, ImageURL = "https://www.meccabeauty.co.nz/on/demandware.static/-/Sites-mecca-online-catalog/default/dwb0e2daa9/product/bumble/hr/i-001993-sunday-shampoo-1-940.jpg",
                ImageAlternativeText="", CategoryID = categories.Single(c=>c.Type == "Oily Hair").Id},
                
                new Product{Name = "Muk Oily Scalp Shampoo", Brand = "Muk Head",
                Description = "Muk Head muk Oily Scalp shampoo helps remove excess oil from the hair and the scalp while still" +
                " rehydrating the ends of the hair, which can often experience dryness. Not to mention this is a gentle and kind formula" +
                " that respects the essential moisture that hair needs to thrive. The result is perfectly balanced hair and protected. ",
                Price = 29.95M, ImageURL = "https://www.adorebeauty.co.nz/pim_media/000/408/701/HeadMuk_Oily-Scalp-Shampoo.png?w=500&h=500&fmt=webp",
                ImageAlternativeText="", CategoryID = categories.Single(c=>c.Type == "Oily Hair").Id},

                new Product{Name = "Deep Cleanse Shampoo", Brand = "KMS Head Remedy",
                Description = "When you want to hit the ‘restore factory settings’ button on your hair, reach for the" +
                " KMS HEADREMEDY Deep Cleanse Shampoo. This well-mannered detox shampoo is gentle, for sure, but it also" +
                " gets the job done. With pomegranate and pepper, it’s formulated to remove product buildup, general grime, " +
                "hard water residue, and a multitude of other sins from all hair types. If your hair is especially oily, you’ll like using it every day, and the rest of us will enjoy it as a weekly refresh. Vegan and made without parabens. ",
                Price = 36, ImageURL = "https://www.adorebeauty.co.nz/pim_media/000/399/294/HR_Deep_Cleanse_Shampoo_300mL.png?w=500&h=500&fmt=webp",
                ImageAlternativeText="", CategoryID = categories.Single(c=>c.Type == "Oily Hair").Id},

                new Product{Name = "Cleansing Oil Shampoo – Anti Oil Astringent Cleanser", Brand = "Shu Uemura",
                Description = "Cleanse and refresh oily hair with Shu Uemura Cleansing Oil Shampoo - Anti Oil Astringent Cleanser. The hair and scalp are deeply cleansed of excess oil, dirt and other impurities, " +
                "leaving the hair clean, light and hydrated.",
                Price = 76, ImageURL = "https://www.adorebeauty.co.nz/media/catalog/product/c/o/co_astringent.png?w=500&h=500&fmt=webp",
                ImageAlternativeText="", CategoryID = categories.Single(c=>c.Type == "Oily Hair").Id},

                new Product{Name = "Original Detox Shampoo", Brand = "O & M",
                Description = "The O&M Detox Shampoo is designed to neutralise and balance excess oil from hair and scalp without drying. It's formulated with a clarifying blend of ingredients to heal, soothe and " +
                "prevent over-production of oil in the hair follicles. Botanical Peppermint is added to cleanse, invigorate and cool the scalp. The O&M Original Detox Shampoo can also be used as a clarifying shampoo.",
                Price = 43, ImageURL = "https://www.adorebeauty.co.nz/media/catalog/product/o/_/o_m_original_detox_shampoo_500.png?w=500&h=500&fmt=webp",
                ImageAlternativeText="", CategoryID = categories.Single(c=>c.Type == "Oily Hair").Id},

                //DRY HAIR
                new Product{Name = "All-soft shampoo for dry hair", Brand = "Redken",
                Description = "Redken All Soft Shampoo is formulated with hydrating argan oil to gently cleanse and soften dry, brittle, damaged hair. Using a smart multi-targeted delivery system, the exclusive RCT " +
                "Protein Complex nourishes hair from the root to the core to the tip, providing custom treatment to all 3 levels and leaving hair soft, silky, and hydrated. With ingredients like soy protein, arginine " +
                "and sepicap, All Soft Shampoo seals in moisture, boosts body, and preps hair for styling.",
                Price = 36, ImageURL = "https://www.adorebeauty.co.nz/pim_media/000/347/009/Redken_All_Soft_Shampoo_for_Dry_Hair_%28P1997200%29_Hero.png?w=500&h=500&fmt=webp",
                ImageAlternativeText="", CategoryID = categories.Single(c=>c.Type == "Dry Hair").Id},

                new Product{Name = "The Therapist Hydrating Shampoo", Brand = "Evo",
                Description = "evo the therapist calming shampoo is a moisturising shampoo to gently cleanse, repair and hydrate colour damaged, dry, coarse, frizzy hair. it helps to strengthen hair, prevent fading of " +
                "colour and reduce frizz. hair is gently cleansed; moisture is replaced.",
                Price = 42.90M, ImageURL = "https://www.adorebeauty.co.nz/media/catalog/product/e/v/evo_the_therapist_hydrating_shampoo_500.png?w=500&h=500&fmt=webp",
                ImageAlternativeText="", CategoryID = categories.Single(c=>c.Type == "Dry Hair").Id},

                new Product{Name = "Chronologiste Bain Shampoo Régénérant", Brand = "Kérastase",
                Description = "Can we interest you in a restorative, energising shampoo? Yes? It’s called Kérastase Chronologiste Bain Shampoo Régénérant 250ml, and we think you’re going to like it. This nourishing," +
                " deep-cleansing shampoo is gentle and moisturising while also bringing a more youthful feel to hair that’s gone a bit dry and brittle. It’s lovely on the scalp, too. A winner. ",
                Price = 61, ImageURL = "https://www.adorebeauty.co.nz/pim_media/000/159/775/BainRegenerant.png?w=500&h=500&fmt=webp",
                ImageAlternativeText="", CategoryID = categories.Single(c=>c.Type == "Dry Hair").Id},

                new Product{Name = "Urban Moisture Shampoo", Brand = "Shu Uemura",
                Description = "Rebalance dry hair and protect against urban stressors with Shu Uemura Urban Moisture Shampoo. Formulated with high levels of antioxidants, this daily shampoo cleanses the hair and scalp" +
                " while adding intense nutrition and protection against environmental aggressors.",
                Price = 54, ImageURL = "https://www.adorebeauty.co.nz/media/catalog/product/u/m/um_shampoo.png?w=500&h=500&fmt=webp",
                ImageAlternativeText="", CategoryID = categories.Single(c=>c.Type == "Dry Hair").Id},

                new Product{Name = "Hydrating Shampoo", Brand = "Mr. Smith",
                Description = "Replenish and restore dry and damaged hair with Mr. Smith Hydrating Shampoo. Gentle enough for daily use, this sulfate-free shampoo" +
                " cleanses the roots and scalp while calming, protecting and restoring dry, thirsty or damaged hair. Packed with nourishing ingredients including " +
                "frankincense, neem seed and marula oils, it helps reverse the effects of UV damage on hair and restores softness and shine.",
                Price = 42.50M, ImageURL = "https://www.adorebeauty.co.nz/pim_media/000/397/931/MR.S103_Mr._Smith_Hydrating_Shampoo_275ml.png?w=500&h=500&fmt=webp",
                ImageAlternativeText="", CategoryID = categories.Single(c=>c.Type == "Dry Hair").Id},

                //FINE HAIR
                new Product{Name = "Fine Intellect Shampoo", Brand = "O & M",
                Description = "The O&M Fine Intellect Shampoo is one of the best ways to add volume and weightless condition to fine limp hair." +
                "  And it's sulphate free! ",
                Price = 43, ImageURL = "https://www.adorebeauty.co.nz/pim_media/000/317/240/O_M_Fine_Intellect_Shampoo_Hero.png?w=500&h=500&fmt=webp",
                ImageAlternativeText="", CategoryID = categories.Single(c=>c.Type == "Fine Hair").Id},

                 new Product{Name = "Full Shampoo", Brand = "VIRTUE",
                Description = "Cleanse, thicken and volumise fine or limp hair with Virtue Full Shampoo. This gentle, sulphate-free formula removes impurities and excess oil from " +
                "the hair and scalp while lifting the roots and plumping strands for weightless, long-lasting body. Enriched with first-of-its-kind Alpha-Keratin 60ku, hair health and " +
                "strength is improved over time",
                Price = 62, ImageURL = "https://www.adorebeauty.co.nz/media/catalog/product/v/i/virtue_full_shampoo_240ml.png?w=500&h=500&fmt=webp",
                ImageAlternativeText="", CategoryID = categories.Single(c=>c.Type == "Fine Hair").Id},

                new Product{Name = "Volume Amplifying Shampoo", Brand = "Davroe",
                Description = "For the fine-haired among us, there’s the Davroe Volume Amplifying Shampoo. It’s lightweight, it’s moisturising, it’s here to add body, shine and volume to thin hair. Volume is right: this gentle cleanser will help your hair turn up. It’s a winner for oily scalps, too, and those that tend to be a little sensitive. " +
                "You can expect softer, fuller hair, with a weightless feel and plenty of shine. Winner.",
                Price = 35.95M, ImageURL = "https://www.adorebeauty.co.nz/pim_media/000/342/519/Davroe_Volume_Amplifying_Shampoo_325ml.png?w=500&h=500&fmt=webp",
                ImageAlternativeText="", CategoryID = categories.Single(c=>c.Type == "Fine Hair").Id},

                new Product{Name = "Volume Injection Shampoo", Brand = "Redken",
                Description = "Take your style to new heights with Redken Volume Injection Shampoo. Ideal for fine or flat hair, this lightweight shampoo" +
                " is formulated with a volume-boosting blend of filloxane and silicone polymers that create lift, enhance body and volume and provide hair with " +
                "a soft, shiny, polished finish. For best results, use daily before Redken’s High Rise Volume Lifting Conditioner.",
                Price = 40, ImageURL = "https://www.adorebeauty.co.nz/pim_media/000/349/153/Redken_High_Rise_Volume_Lifting_Shampoo_%28P2004200%29_Hero.png?w=500&h=500&fmt=webp",
                ImageAlternativeText="", CategoryID = categories.Single(c=>c.Type == "Fine Hair").Id},


                //THICK HAIR

                new Product{Name = "Moisture Balancing Shampoo", Brand = "Phillip Kingsley",
                Description = "If you’re looking for a Goldilocks shampoo - one that really cleanses, but won’t dry your hair - Philip Kingsley Moisture " +
                "Balancing Shampoo may well be it. Designed for medium thickness hair that tends to get oily at the root while drying out at the ends, it’s " +
                "set to bring some harmony back to your hair. Expect added shine and bounce, too. Love it.",
                Price = 49, ImageURL = "https://www.adorebeauty.co.nz/media/catalog/product/m/o/moisture_balancing_shampoo_250ml_2_.png?w=500&h=500&fmt=webp",
                ImageAlternativeText="", CategoryID = categories.Single(c=>c.Type == "Thick Hair").Id},

                new Product{Name = "Thick Hair Shampoo", Brand = "Ouai",
                Description = "This rich, moisturizing shampoo strengthens and calms thick hair with keratin, smoothing marshmallow root, shea butter, " +
                "and avocado oil to fight frizz from the start. So cancel that blowout appointment - you won’t need it.",
                Price = 52, ImageURL = "https://image-optimizer-reg.production.sephora-asia.net/images/product_images/closeup_1_Product_815402021283-Ouai-Thick-Hair-Shampoo-300ml_a584acf4c175c59e04d3cae305f4a2ecbc078117_1584930123.png",
                ImageAlternativeText="", CategoryID = categories.Single(c=>c.Type == "Thick Hair").Id},

                new Product{Name = "Discipline Bain Fluidealiste 2", Brand = "Kérastase",
                Description = "For thick, overprocessed and unruly hair, there’s the Kérastase Discipline Bain Fluidealiste 2 Shampoo. " +
                "This sulfate-free cleanser offers softer, more agreeable hair, as well as reducing frizz and softening the hair. If you've gone " +
                "a bit hard on the hot tools and the colour processes, you’ll want to know about this one. It’s essentially the shampoo equivalent " +
                "of a glass of wine in the bath: very, very soothing and also quite luxurious. Best used in chorus with the rest of the Kérastase Discipline range",
                Price = 53, ImageURL = "https://www.adorebeauty.co.nz/pim_media/000/264/432/BainFluidealisteShampoo.png?w=500&h=500&fmt=webp",
                ImageAlternativeText="", CategoryID = categories.Single(c=>c.Type == "Thick Hair").Id},
                
                //CURLY HAIR

                new Product{Name = "Be Curly Shampoo", Brand = "Aveda",
                Description = "Calling all curly and wavy manes— this gentle shampoo will maintain and nourish your natural curl, giving your hair the TLC it deserves. " +
                "Gentle enough for daily use, hair is left bouncy and soft, curls are defined, frizz is tamed and shine is enhanced",
                Price = 150, ImageURL = "https://www.meccabeauty.co.nz/on/demandware.static/-/Sites-mecca-online-catalog/default/dwdf6b11ed/product/aveda/hr/i-032753-be-curly-shampoo-1l-1-940.jpg",
                ImageAlternativeText="", CategoryID = categories.Single(c=>c.Type == "Curly Hair").Id},

                new Product{Name = "Curl Charisma Rice Amino + Avocado Hydrating Shampoo", Brand = "Briogeo",
                Description = "This sulphate-free shampoo is fortified with rice amino acids that seal the hair cuticle and lock out frizz-causing humidity. Tomato fruit ferment enhances moisture " +
                "retention to support uniform curl formation. Ultra-hydrating shea butter and avocado oil enhance softness without weighing hair down. Formulation is 97% naturally derived, 6-free™ " +
                "and made with Briogeo's NOVA Complex.",
                Price = 62, ImageURL = "https://www.meccabeauty.co.nz/on/demandware.static/-/Sites-mecca-online-catalog/default/dwba4b368f/product/brioge/hr/i-045579-curl-charisma-rice-amino-avocado-hydrating-shampoo-1-940.jpg",
                ImageAlternativeText="", CategoryID = categories.Single(c=>c.Type == "Curly Hair").Id},

                new Product{Name = "Curl Shampoo", Brand = "Virtue",
                Description = "This one goes out to our curly-headed friends, our coily-haired honeys. The Virtue Curl Shampoo has been formulated especially for curly " +
                "hair of all types, and it’s set to heal and protect your hair as it cleanses. You can expect soft, bouncy, resilient hair, thanks to its high moisture content" +
                " and Virtue’s own Alpha Keratin 60ku protein. Great stuff. ",
                Price = 62, ImageURL = "https://www.adorebeauty.co.nz/pim_media/000/312/134/virtue_shampoo_full_500.png?w=500&h=500&fmt=webp",
                ImageAlternativeText="", CategoryID = categories.Single(c=>c.Type == "Curly Hair").Id},

                //DAMAGED HAIR
                new Product{Name = "Nourish Shampoo", Brand = "NAK Hair",
                Description = "For hair that needs to be handled with care, there’s the NAK Nourish Shampoo 375ml. This soft touch of a cleanser has been formulated to " +
                "freshen your hair without stripping it. Aimed at dry and damaged hair, this shampoo is also ideal for coloured hair, since it’s both strengthening and gentle. " +
                "You can expect increased shine and elasticity, plus a longer-lasting colour. Dream result, if you’re asking us. ",
                Price = 8, ImageURL = "https://www.adorebeauty.co.nz/pim_media/000/154/484/NAK_Hair_Nourish_Shampoo_375ml_%28NNS375%29.png?w=500&h=500&fmt=webp",
                ImageAlternativeText="", CategoryID = categories.Single(c=>c.Type == "Damaged Hair").Id},

                new Product{Name = "No. 4 Bond Maintenance Shampoo", Brand = "Olaplex",
                Description = "For hair that's seen better days, there's the Olaplex No.4 Bond Maintenance Shampoo. If you're a fan of the rest of Olaplex's line - you know, " +
                "the treatment, the oil, all of that - this one has your name on it. Designed for locks in distress, this Olaplex shampoo is formulated with Olaplex's bond-building " +
                "ingredient. With an incredibly concentrated formula, it works together with the Olaplex No.5 Bond Maintenance Conditioner, and Olaplex 3 to help restore internal strength " +
                "and moisture levels. Your hair is left feeling softer, with a shinier, healthier looking finish. Designed to improve the manageability of all hair types. ",
                Price = 60, ImageURL = "https://www.adorebeauty.co.nz/pim_media/000/269/813/Olaplex-no.4-with-badges.png?w=500&h=500&fmt=webp",
                ImageAlternativeText="", CategoryID = categories.Single(c=>c.Type == "Damaged Hair").Id},

                new Product{Name = "Ritual Salvation Repairing Shampoo", Brand = "Evo",
                Description = "evo ritual salvation shampoo is a gentle, moisturising shampoo for dry or damaged hair.",
                Price = 42.90M, ImageURL = "https://www.adorebeauty.co.nz/media/catalog/product/e/v/evo_ritual_salvation_shampoo_new_500.png?w=500&h=500&fmt=webp",
                ImageAlternativeText="", CategoryID = categories.Single(c=>c.Type == "Damaged Hair").Id},
                
                //STRAIGHT HAIR
                new Product{Name = "Kerasilk Reconstruct Shampoo", Brand = "Goldwell",
                Description = "If the years have been hard on your hair - if you’ve processed it to within an inch of its life, and still won’t stop heat styling," +
                " you might like to think about using Goldwell Kerasilk Reconstruct Shampoo. This easygoing (but powerful) shampoo is ideal for damaged, stressed hair " +
                "that’s seen better days. If you’re dealing with dull texture, split ends and breakage, step this way. It’s made to strengthen and soften your hair, and " +
                "cleanse without stripping",
                Price = 41, ImageURL = "https://www.adorebeauty.co.nz/media/catalog/product/k/e/kerasilk_reconstruct_shampoo.png?w=500&h=500&fmt=webp",
                ImageAlternativeText="", CategoryID = categories.Single(c=>c.Type == "Straight Hair").Id},

                new Product{Name = "White truffle Shampoo", Brand = "Phillip B.",
                Description = "Heavenly hydration is made easy with a series of nourishing botanicals and fortifying lipids all wrapped up in this sumptuous shampoo." +
                " A rich, deep cleansing formula, this shampoo cleanses and hydrates even the coarsest, most damaged hair. Containing a restorative blend of 23% active " +
                "botanical hydrators, including Italian white truffle oil for strengthening, hops to tone and add shine, nettle and thyme to clarify as well as soften. " +
                "A potent soy protein to smooth and strengthen and panthenol to seal split ends. Working to repair strands from the inside out whilst adding softness and " +
                "shine minus the heavy texture. This shampoo is suitable for all textures, lengths and processed hair.",
                Price = 128, ImageURL = "https://www.meccabeauty.co.nz/on/demandware.static/-/Sites-mecca-online-catalog/default/dw8d46616b/product/philip/hr/i-038880-white-truffle-shampoo-1-940.jpg",
                ImageAlternativeText="", CategoryID = categories.Single(c=>c.Type == "Straight Hair").Id},

                new Product{Name = "Revitalising Shampoo", Brand = "Balmain Paris",
                Description = "Enhance hair softness and manageability with Balmain Paris Revitalizing Shampoo. Ideal for dry or damaged hair, this formula contains a cocktail " +
                "of vitamins to repair, strengthen and nourish, leaving hair touchably soft and smooth.",
                Price = 56.72M, ImageURL = "https://www.adorebeauty.co.nz/media/catalog/product/b/a/balmain_paris_revitalizing_shampoo_300ml.png?w=500&h=500&fmt=webp",
                ImageAlternativeText="", CategoryID = categories.Single(c=>c.Type == "Straight Hair").Id},

            };
            products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();

        }
    }
}
