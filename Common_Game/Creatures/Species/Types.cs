using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Creatures.Species
{
    // This enum is primarily used to make it easier to tally-up species scores and deal
    // with various conditionals.
    public enum Type
    {
        None, // TODO: Figure out how to handle when a species doesn't have a body part.  Placeholder type.
              //       May be reconfigured as a value to be used with parts that don't have a particular
              //       associated species (like `Anus`).
        Normal, // TODO: Used for `Claws`.  Not sure how to standardize yet.
                // TODO: Used in `Neck` with the comment "// Normal human neck. Length = 2 inches"
                // TODO: Used for `Testicle` to differ from Bunny "testicles".  Might rename `Testicle` to `Ball`
        Undefined, // TODO: Used for `Cock`.  Not sure how yet.
        Anemone,
        Avian, // TODO: Used for `Cock`.  Not sure if a specific species or shared across all avians.
        Basilisk, // TODO: Seen as `BasiliskSpines` and `BasiliskPlume` in `Hair`
        Bat, // TODO: Only seen in `Wings`
             // TODO: Seen as `BatLikeTiny` and `BatLikeLarge` in `Wings`
        Beak, // TODO: in `Face`: "This is a placeholder for the next beaked face type, so feel free to refactor (rename)"
        Bee, // TODO: Seen as `BeeAbdomen` in `Tail`.  Might need to rethink the section.
             // TODO: Seen in `Wings` as `BeeLikeSmall` and `BeeLikeLarge`
        Behemoth, // TODO: Seen in `Tail`
        Boar, // TODO: Just a male version of `Pig` in `Face`?
        Buckteeth, // TODO: Seen in `Face`.  `Bunny` precursor?
        Bunny,
        Cat, // TODO: `Face` had both `Cat` and `Catgirl`
      /*Centaur,*/ // TODO: From `LowerBody` "//DEPRECATED - USE HOOFED + LEGCOUNT 4"
        ClovenHoofed, // TODO: Seen in `LowerBody`.  Group-level?
        Cockatrice,
        Cow, // TODO: Seen as `CowMinotaur` in `Face` and `Horns`
        Deer, // TODO: Seen as `Antlers` in `Horns`
      /*Deertaur,*/ // TODO: From `LowerBody`. "//DEPRECATED - USE CLOVEN HOOFED + LEGCOUNT 4"
        Demon, // TODO: Seen in `LowerBody` as `DemonicHighHeels` and `DemonicClaws`
               // TODO: Seen occasionally as `Demonic`
        Displacer,
        Dog,
        Dragon, // TODO: `DraconicMane` and `DraconicSpikes` seen in `DorsalArea`
                // TODO: Seen as `Draconic_x2` and `Draconic_x4_12_inch_long` in source `Horns`
                // TODO: Seen as `Draconic` in `Neck` with the comment "// (Western) Dragon neck. Length = 2-30 inches"
                // TODO: Seen occasionally as `Draconic`
                // TODO: Seen as `DraconicSmall` and `DraconicLarge` in `Wings`
        Dragonfly, // TODO: Only seen in `Wings`, and there as `GiantDragonfly` ("Giant" probably referring to size rather than species)
        Echidna,
        Elfin,
        Faerie, // TODO: Same as Elfin?
                // TODO: Only seen in `Wings`
                // TODO: Seen as `FaerieSmall` and `FaerieLarge` in `Wings` with the (duplicated) comment "currently for monsters only"
        Feather, // TODO: Seen in `Hair`.  Generic/Group-level?
                 // TODO: Seen as `FeatheredLarge` in `Wings`
        Ferret, // TODO: `Face` had both `FerretMask` and `Ferret`
        Fish, // TODO: Seen in `Gills`.  Generic/Group-level?
        Fox,
        Goat,
        Ghost, // TODO: Seen in `Hair`.  Modifier rather than species type?
        Goo,
        Harpy,
        Horse,
        Human,
        Hoofed, // TODO: Seen in `LowerBody`.  Probably Group-level.
        Imp, // TODO: Seen as `ImpLarge` in `Wings`
        Kangaroo,
        Leaf, // TODO: Seen in `Hair`.  Generic/Group-level?
        Lizard,
        Mantis, // NYI! Placeholder for Xianxia mod
        Mouse,
        Naga,
        Pig,
        Pony, // TODO: Seen in `LowerBody`
        Predator,
        Quill, // TODO: Seen in `Hair`.  Generic/Group-level?
        Rabbit, // TODO: Seen in `Tail`.  Synonym for `Bunny`?
        Raccoon, // TODO: `Face` had both `RaccoonMask` and `Raccoon`
        Ram, // TODO: Seen in `Horns`.  Just male Sheep?
        RedPanda,
        Rhino, // TODO: Commented out in `LowerBody` only
        Salamander,
        SandTrap, // TODO: From `Eyes`, but I don't recall seeing sandtrap stuff anywhere else?
        Scorpion, // TODO: Seen in `Tail`
        Shark, // TODO: `SharkFin` seen in `DorsalArea`
               // TODO: Seen as `SharkTeeth` in `Face`
               // TODO: Seen as `SharkFin` in `Wings` with the comment "Deprecated, moved to the rearBody slot"
        Sheep, // TODO: Seen as `Wool` in `Hair`.  Generic/Group-level?
        Snake, // TODO: Seen as `SnakeFangs` in `Face`
        Spider, // TODO: `Spider` has special eye qualities - can have four (or more?).
                // TODO: Seen as `SpiderFangs` in `Face`
                // TODO: Seen as `ChitinousSpiderLegs` and `Drider` in `LowerBody`
                // TODO: Seen as `SpiderAbdomen` in `Tail`.  Might need to rethink the section.
        Tentacle, // TODO: Probably not the same as a species.  Used by `Cock`.
        Unicorn, // TODO: Seen in `Horns`
        Wolf,
    }
    public enum SkinType
    {
        Undefined, // DEPRECATED, silently discarded upon loading a saved game
        Plain,
        Bark,
        Cockatrice, // TODO: From `VentralArea`
        DragonScales,
        Feathered,
        FishScales, // NYI, for future use
        Fur, // TODO: Seen as `Furry` in `VentralArea`
        Goo,
        LizardScales,
        Naga, // TODO: From `VentralArea`
        Reptile, // TODO: From `VentralArea`.  Probably the same as `LizardScales`.
        Wool,
    }
}
