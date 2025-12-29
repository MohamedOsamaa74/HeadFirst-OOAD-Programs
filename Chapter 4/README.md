# Doug's Dog Door – Head First OOA&D (Chapter 4)

This project is an implementation of the **Doug's Dog Door** example from
**Chapter 4 of *Head First Object-Oriented Analysis & Design***.

The goal of this program is to demonstrate how **refining requirements leads to introducing new domain objects**, improving system accuracy while keeping the design flexible and object-oriented.

---

## Chapter Focus

Chapter 4 focuses on:

* Refining requirements to handle real-world complexity
* Introducing value objects to model domain concepts
* Improving system accuracy without breaking existing behavior
* Strengthening encapsulation and responsibility boundaries
* Designing for correctness, not just functionality

---

## What This Program Does

* Simulates a dog door that opens automatically when a recognized dog barks
* Introduces a `Bark` class to model dog sounds as domain objects
* Allows the system to store and compare **authorized barks**
* Prevents unauthorized dogs from opening the door
* Demonstrates realistic decision-making based on object comparison

---

## What Changed from Chapter 3

Chapter 4 builds directly on Chapter 3, but improves the design by addressing an important real-world problem.

---

### 1. New Domain Object: `Bark`

* **Chapter 3:**
  Bark sounds were represented as plain strings.
* **Chapter 4:**
  Bark sounds are modeled as a dedicated `Bark` class.
  This makes barking a **first-class concept** in the system instead of raw data.

---

### 2. Bark Authorization Logic

* The `DogDoor` now maintains a list of **allowed barks**.
* The `BarkRecognizer` checks incoming barks against this list.
* Only matching barks can open the door.

This prevents unauthorized dogs from triggering the system.

---

### 3. Improved System Accuracy

* The system no longer reacts to *any* bark.
* It reacts only to **recognized and approved barking patterns**.
* This mirrors real-world behavior more closely.

---

### 4. Better Responsibility Distribution

* `DogDoor` is responsible for:

  * Managing door state
  * Storing allowed barks
* `BarkRecognizer` is responsible for:

  * Detecting barks
  * Deciding whether a bark is valid
* Actors do not control system logic directly.

---


## Concepts Practiced

* Domain-driven thinking
* Value objects
* Encapsulation of business rules
* Responsibility-driven design
* Incremental design evolution
* Preparing systems for change

---

## Project Purpose

This project is part of my personal practice while studying **Head First OOA&D**, where I:

* Implement each chapter incrementally
* Observe how small requirement changes affect design
* Practice identifying when to introduce new objects
* Strengthen object-oriented reasoning using realistic scenarios

---

## Reference

* Book: **Head First Object-Oriented Analysis & Design**
* Chapter: **Chapter 4 – Make Sure Objects Do What You Expect Them To Do**

---

Feel free to compare this chapter with Chapters 2 and 3 to clearly see how the design becomes more precise and robust over time.
