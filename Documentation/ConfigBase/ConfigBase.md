[configbase]: ./../ConfigBase/ConfigBase.md
[manual]: ./manual.md

# ConfigBase
class in UIConfigSystem / Implemented in: UIConfigSystem Package<br>
[SWITCH TO MANUAL][manual]

### Description
Abstract generic base class for config to hold a reference to be compared to.
The reference is used to identify and get the data implemented in derived classes 
corresponding to the contained reference.

### Properties
> | Property    | Description
> | :-          | :-
> | Reference   | Instance referenced by this config for identification

### Constructors
> | Constructor | Description
> | :-          | :-
> | ConfigBase  | Base constructor with optional parameter

### Public Methods
> | Method       | Description
> | :-           | :-
> | GetReference | Get referenced instance
> | SetReference | Set referenced instance
> | Compare      | Identify by referenced instance