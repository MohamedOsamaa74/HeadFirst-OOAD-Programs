# Doug's Dog Door – Head First OOA&D (Chapter 3)

This project is an implementation of the **Doug's Dog Door** example from
**Chapter 3 of *Head First Object-Oriented Analysis & Design***.

The goal of this program is to demonstrate how **requirements changes lead to design changes**, and how responsibilities can be reassigned to improve flexibility and realism in an object-oriented system.

---

## Chapter Focus

Chapter 3 focuses on:

* Responding to new and changing requirements
* Reassigning responsibilities between classes
* Reducing tight coupling between actors and system logic
* Letting objects manage their own behavior
* Evolving a design instead of rewriting it

---

## What This Program Does

* Simulates a dog door that can be opened automatically
* Introduces a **bark recognition system** that opens the door when a dog barks
* Allows the door to close automatically after a delay
* Supports multiple actors interacting with the same system (remote control and bark recognizer)
* Demonstrates a more realistic, event-driven interaction model

---

## What Changed from Chapter 2

Chapter 3 builds directly on Chapter 2, but introduces important design improvements:

### 1. Responsibility Shift

* **Chapter 2:**
  The `Remote` was responsible for opening the door *and* deciding when to close it.
* **Chapter 3:**
  The `DogDoor` itself is responsible for opening **and automatically closing** after a delay.
  This makes the `DogDoor` a smarter object that manages its own behavior.

---

### 2. New Actor: BarkRecognizer

* A new class, `BarkRecognizer`, represents a real-world device that listens for a dog’s bark.
* It interacts with the system **without knowing how the door works internally**.
* This reinforces separation between **actors** and **system logic**.

---

### 3. Reduced Coupling

* Actors (`Remote`, `BarkRecognizer`) no longer control timing or door state logic.
* They simply request an action (`OpenDoor`).
* This makes the system easier to extend (e.g., adding cameras, sensors, or mobile apps later).

---

### 4. More Realistic Design

* The system now better reflects real-world behavior:

  * The dog can bark instead of relying on a human with a remote.
  * The door closes itself after the dog passes through.
* The design supports **multiple triggers** for the same behavior.

---

## Concepts Practiced

* Object-Oriented Design Evolution
* Responsibility reassignment
* Low coupling between actors and system
* Encapsulation of behavior
* Event-driven thinking
* Designing for change

---

## Project Purpose

This project is part of my personal practice while studying **Head First OOA&D**, where I:

* Implement chapter examples incrementally
* Observe how design changes follow requirement changes
* Strengthen object-oriented thinking through realistic scenarios
* Prepare the design for further enhancements in later chapters

---

## Reference

* Book: **Head First Object-Oriented Analysis & Design**
* Chapter: **Chapter 3 – I Love You, You're Perfect... Now Change**

---

Feel free to explore the code and compare it with Chapter 2 to clearly see how the design evolves.
