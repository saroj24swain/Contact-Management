import { Component, EventEmitter, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-contact-form',
  // imports: [],
  templateUrl: './contact-form.component.html',
  styleUrl: './contact-form.component.css'
})
export class ContactFormComponent {
  contactForm: FormGroup;
  

  @Output() formSubmit = new EventEmitter();

  constructor(private fb: FormBuilder) {
    this.contactForm = this.fb.group({
      id: [0],
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
    });
  }
  onSubmit() {
    if (this.contactForm.valid) {
      this.formSubmit.emit(this.contactForm.value);
      this.contactForm.reset();
    }
  }
}
