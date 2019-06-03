# Bounded Numeric Statistic
## Setters and Modifiers
### Setters
**Setters** provide a limiting value ("don't go higher/lower than this").
The highest/lowest setter (as appropriate) is chosen.

There are two varieties of setters:
* **Static Setters** adjust by a set value.
* **Dynamic Setters** adjust by a value dependant on other values.

### Modifiers
**Modifiers** adjust values up/down by some amount.  They come in two varieties:
* **Static Modifiers** adjust by a set value.
* **Dynamic Modifiers** adjust by a value dependant on other values.

When modifiers and setters apply to the same target, modifiers are split into two groups:
* **PreSetter Modifiers** apply before evaluating setters.  They are summed with a base value and compete against the setters.
* **PostSetter Modifiers** adjust the chosen setter value.

## Properties
### Identities and Ordering
1. Set **LowerBound**: Bottom of scale
2. Set **UpperBound**: Top of scale
3. Set **Minimum**: Lowest that Value can go
4. Set **Maximum**: Highest that Value can go
5. Set **Value**: Current value of the statistic.

### Boundaries
LowerBound and UpperBound have three settings:
* **BaseValue**: The initial setting of the boundary. *(Typically 0 and 100, respectively.)*
* **Minimum**: How low the boundary can be adjusted. *(HP's upper bound can be as low as 50.)*
* **Maximum**: How high the boundary can be adjusted. *(HP's upper bound can be as high as 9999.)*

UpperBound limits itself to go no lower than LowerBound.

#### LowerBound
LowerBound has the following modifiers and setters:
* **StaticModifiers**: Summed and added to BaseValue

#### UpperBound
UpperBound has the following modifiers and setters:
1. **StaticModifiers**: Summed and added to BaseValue
2. **DynamicModifiers**: Summed and added to (1). *(HP's upper bound is dependent on toughness, among other things.)*
	* *Input*: the result of (1).

### Minimum and Maximum
Minimum and Maximum are adjusted through modifiers and setters only, as their base values are derived from LowerBound and UpperBound.

Minimum and Maximum have the following base values, by reference:
* **BaseLowerLimit**: The value of LowerBound.
* **BaseUpperLimit**: The value of UpperBound.

#### Minimum
Minimum has the following base values, by reference:
* **BaseValue**: The value of LowerBound.

BaseValue becomes **UncheckedValue** after evaluating the following:
* **PreSetterStaticModifiers**
* **StaticSetters**
* **DynamicSetters**
* **PostSetterStaticModifiers**
* **PostSetterDynamicModifiers**

BaseUpperLimit becomes **UpperLimit** after evaluating the following:
* **UpperLimitStaticSetters**

UncheckedValue is moved the minimal amount needed to satisfy the relation:
> BaseLowerLimit ≤ UncheckedValue ≤ UpperLimit

#### Maximum
Maximum has the following base values, by reference:
* **BaseValue**: The value of UpperBound.

BaseValue becomes **UncheckedValue** after evaluating the following:
* **PreSetterStaticModifiers**
* **StaticSetters**
* **DynamicSetters**
* **PostSetterStaticModifiers**
* **PostSetterDynamicModifiers**

BaseLowerLimit becomes **LowerLimit** after evaluating the following:
* **LowerLimitStaticSetters**

UncheckedValue is moved the minimal amount needed to satisfy the relation:
> LowerLimit ≤ UncheckedValue ≤ BaseUpperLimit

#### UncheckedValue to Value
If the UncheckedValues of Minimum and Maximum pass each other, they are each set to their combined average to produce their final Values.  Otherwise, they become their respective Value as is.

### Value
Value has the following modifier collections:
* **StaticModifiers**

Value has the following event-specific modifier collections:
* **OnAdjusting** *(dynamic modifiers)*: Applied when Value is adjusted (increased or decreased).
	* *Input*: the base amount of the increase or decrease.

## Relations
Property relations:
> LowerBound ≤ Minimum ≤ Value ≤ Maximum ≤ UpperBound 

Per-property internal relations:
* LowerBound: Minimum ≤ Value ≤ Maximum
* UpperBound: Minimum ≤ Value ≤ Maximum
* Minimum: BaseLowerLimit ≤ Value ≤ UpperLimit
* Maximum: LowerLimit ≤ Value ≤ BaseUpperLimit
