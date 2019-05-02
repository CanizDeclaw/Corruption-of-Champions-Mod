BodyPart modification responsibility
====================================

All code revolving around the *modification* of body parts is relegated to the relevant derivative class, for a few reasons:
* NPCs with only basic interactions don't need it - they don't change in the first place,
* NPCs that do change will do it through means other than PC mechanics anyway, and
* It prevents us from having to maintain more complex parent-child reference relations to figure out things like whether a PC perk is relevant to a prospective change.

As such, any modification code is placed as late in the hierarchy as possible, and basic body parts have very little code beyond what is needed to create, reset, and describe the bodypart.