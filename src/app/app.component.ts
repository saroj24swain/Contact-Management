import { Component, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ContactService } from './contact.service';
import { Contact } from './model/contact.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  contactList: Contact[] = [];

  constructor(private contactService: ContactService) {}

  ngOnInit() {
    this.loadContacts();
  }

  loadContacts() {
    this.contactService.getContacts().subscribe(data => {
      this.contactList = data;
    });
  }

  onFormSubmit(contact: Contact) {
    this.contactService.addContact(contact).subscribe(() => {
      this.loadContacts();
    });
  }

  onDeleteContact(id: unknown) {
    if (typeof id === 'number') {
      this.contactService.deleteContact(id).subscribe(() => {
        this.loadContacts();  // Reload contacts after deletion
      });
    } else {
      console.error('Invalid ID type');
    }
  }
}
