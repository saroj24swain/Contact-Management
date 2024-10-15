import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Contact } from '../model/contact.model';

@Component({
  selector: 'app-contact-list',
  templateUrl: './contact-list.component.html',
  styleUrl: './contact-list.component.css'
})
export class ContactListComponent {
  @Input() contactDetailList: Contact[] = [];

  @Output() deleteContact = new EventEmitter<number>();

  onDeleteContact(id: any) {
    this.deleteContact.emit(id); // Emit the contact id
  }
}
