using UnityEngine;
using TMPro;

public class descriptions : BaseListBank
{
    private string[] _contents = {
             //All Shapes
     "A container of all possible shapes within its own physical constraints. Shapes are presented iteratively as part of a\u00A0sequence with stochastic origins. Each newly selected shape has maximally contrasting features to those, that have been previously displayed.",
          //Untitled (semantic bounds violation)
     "This work attempts to examine the problem of semantic interpretation of different artworks by various audiences through self-reference and composition utilizing intercultural features in perception based on the latest research in neuroaesthetics. Construction of a “path” through order, contrast and causality as well as avoiding any dependency on symbols.\n " +
            "Main objects are distinguished from others by placement, size, different material (very material impasto technique with layers of paint sticking out of the board x immaterial digital visualization) and by being interacted with.\n" +
            "Meaning can emerge both from a singular object on its own and objects together as a specific group.\n" +
            "Ever-changing reflections on the bottle as relatively infinite contexts within, which to interpret the object that remains identical.\n" +
            "Depicted are actions of the “observer” reaching in (to the “painting”) and searching for all conceivable relations linked to interpretations from their current accessible memory = magnifying glass. \n" +
            "Selecting from the scope of the possible meanings = pointing to a fixed projection on the vase. Taking out and interpreting something outside of its assigned context = scissors. These all could in a way be considered symbols, but I would argue that all of the above is just an outcome of their primary use. \n" +
            "The “name” semantic bounds violation would refer to the case when not all variables surrounding the artwork are considered and chosen interpretation is outside of the scope/bounds of all the logically sound.",
     //2021 freesounds & all their 5 beat rhythms (1.406704e+12) 2021
     "Despite my view of art as a pursuit of novelty and intellectual entertainment, I position artworks existing as everyday objects to be superior to ones that are not.  This hierarchy, I believe, is a momentary necessity due to the current resource-scarce reality. Although, there must be a gray area, depending on the trade-offs in the degree of innovation achieved, be it functional or not. \n \n It is a juxtaposition of great differences rather than subtle adjustments that provide, in such vastness of variability, interesting results. The system of maximum contrast pattern selection operating inside of the table is visually uncovered in the form of the two boxes.",
    //FreesoundPercussion2020
    "All possible rhythmical progressions of 3 instruments within 5 beats, using a dataset of all percussive sounds available on freesound.org at the end of 2020, embedded in a functional cutting board. Instruments change after all 1023 permutations are exhausted, but do not repeat. Each following permutation of sounds is picked to be as different as possible from the previous ones.",
    //8063-1
    "First produced sound, inside the space, starts to be played (per second) in each possible permutation of a \n5-second duration (31). The frequency and length are registered and await for a second sound. If there is none and all the permutations have been iterated through the whole pattern gets rewinded to the beginning and code waits for a new first sound input. If there happens to be a second input. Its’ frequency and length, in specified ranges (short, medium, high), are compared to that of the first sound. If it matches input is discarded. If not, the pattern played up to this point gets rewinded and all the permutations of these two sounds(242) start to be played. Identical process follows for the third sound input. Once it is found all the permutations for all the three sounds(1023) get played until the end. Rewinding afterwards to the very beginning.\nThe permutations are divided by a beep scaled from 80 to 15500 Hz as to present an idea of time and end. In order to avoid any otherwise necessary visual cues.",
    //creation of adam
    "Ancient paradigm unfolds before the viewer within contemporary form. In this instance creation is not a\u00A0mere 2D illusion. Spectator can take on the role of a mediator. Allowing the artwork to take place and assess the foregoing events. Did (image of) Adam came into existence by connecting a USB cable with a computer? Or did the image exist elsewhere prior to that? Composition mimics the original painting. With a device on the bottom left and cable coming from the top right. Device if stationary on the chair is motionless (Adam) while the whole action is executed by moving the cable (god).",
    //aesthetic alignment pt. 2 (landscape)
    "The second component of the same-titled work. Major feature of the 1st part, the shock by examination, seemed little bit impractical. Since it cannot be expected for every viewer to go through the pile of given photos. Therefore this second part takes the role of conveying it in a more showcase-able way. A framed  3D collage made out of sewn together and overlapping photographs of the same format, clothless, depicting landscape. Interlinked with a blue/red yarn representing the previous alignment of its parts (body) in the form and operating direction of veins/arteries. Oxygenated red goes down and blue goes up. If the images are on the same level in the collage both colors are used.",
    //genesis of failure
    "Based on the realization while drawing, what was supposed to be a realistic portrait of my pediatrician meant as a gift. After several hours of work drawing turned into everything, but realistic. Therefore it failed in its sole purpose - make the portrayed person recognizable. Which in afterthought, I concluded to be an unavoidable process of the brain, that has weak synaptic connections in this area.  The cutout text symbolizes and also functions as a notional filter. Trough, which all the information has to pass. To allow for making an actual line in the drawing itself.",
    //aesthetic alignments 1
    "Stack of photographs of abstract details and at the bottom an image of the composition of all the pictures present in the stack in the form of a body in a defensive stance. Resulting in supply of meaning into the obliviousness, but mainly a little shock value, because parts of what was once something, which seems like a being, are unknowingly found in the viewers' hands.  Probably by violence, hence the posture.",
    //website
    "Experimental analogy of my portfolio in ever-changing, according to the current purpose, virtual space accessed through a website. In this very first version, I intended to create classic white box environment focused on relationship between artworks and space. And to evoke a feeling of retrospective “journey” in approach to art. We start in a relatively humble room with a landscape view and figure drawings, representing presumptive overview of the nature of art. We rise upon the steps. The forms are starting to get more abstract with some interest in an actual idea or content. Just to sink again into a large room further opening up to conceptual darkness with hints of light in the distance symbolizing mystery and unexplored aspects of given topics/forms. The name of the website was formed according to the surrealistic game “exquisite corpse“. In my interpretation of the game, I asked people, who I consider closest, about certain words (in a sequence of word classes to allow for forming a sentence) reminding them of me in an indirect way. Later I randomly draw, which word from which person is going to be in a certain spot in the sentence. The extension at the end of the website address alludes to that the sentence is actually myself in the mind of others.",
    };

    public override string GetListContent(int index)
    {
        return _contents[index];
    }

    public override int GetListLength()
    {
        return _contents.Length;
    }
}

